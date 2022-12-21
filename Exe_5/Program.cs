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

    }
}
