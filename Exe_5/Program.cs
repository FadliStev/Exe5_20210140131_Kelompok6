using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_5
{
    class Node
    {
        public string name;
        public Node next;
        
    }
    class Queue
    {
        public Node wiranto, fadlillah;

        public Queue()
        {
            wiranto = null;
            fadlillah = null;
        }
        public void Insert()
        {
            string add;
            Node newnode= new Node();
            Console.WriteLine("Masukkan Element :");
            add = Console.ReadLine();
            newnode.name = add;
            newnode.next = fadlillah;
            if(wiranto == null)
            {
                wiranto = newnode;
                fadlillah = newnode;
                return;
            }
            fadlillah.next = newnode;
            fadlillah = newnode;
        }
        public void Delete()
        {
            if(wiranto == null)
            {
                Console.WriteLine("\nList is Empty");
                return;
            }
            fadlillah = fadlillah.next;
            if (wiranto == null)
                fadlillah = null;
        }
        public void Display()
        {
            if(fadlillah == null)
            {
                Console.WriteLine("\nQueue is Empty");
                return ;
            }

        }

    }
}
