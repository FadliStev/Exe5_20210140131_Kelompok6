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
            newnode.next = null;
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
            wiranto = wiranto.next;
            if (wiranto == null)
                fadlillah = null;
        }
        public void Display()
        {
            if(wiranto == null)
            {
                Console.WriteLine("\nQueue is Empty");
                return;
            }
            Node display;
            for(display = wiranto; display != null; display = display.next)
                Console.WriteLine(display.name);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue qe = new Queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1.Menambah Data ke dalam List");
                    Console.WriteLine("2.Menghapus Data dari dalam List");
                    Console.WriteLine("3.Melihat semua data di dalam list");
                    Console.WriteLine("4.Exit");
                    Console.Write("Masukkan pilhan anda (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {
                        case '1':
                            qe.Insert();
                            break;
                        case '2':
                            qe.Delete();
                            break;
                        case '3':
                            qe.Display();
                            break;
                        case '4':
                            return;
                        default:
                            Console.WriteLine("Wrong Option");
                            break;
                    }

                    
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nCheck for the value entered ");
                }
            }

        }
    }
}
