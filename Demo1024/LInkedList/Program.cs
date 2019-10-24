using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            // create a new LinkedListNode of type String and display its properties
            LinkedListNode<String> lln = new LinkedListNode<string>("orange");
            Console.WriteLine("display properites");
            DisplayProperties(lln);
            Console.WriteLine();

            // create linked list
            LinkedList<String> ll = new LinkedList<string>();
            ll.AddLast(lln);
            Console.WriteLine("after adding node to list");
            DisplayProperties(lln);
            Console.WriteLine();

            // add more nodes to linked list
            // Add is creating the node for me with the value of red etc.
            ll.AddFirst("red");
            ll.AddLast("yellow");
            Console.WriteLine("after adding other nodes to my list");
            DisplayProperties(lln);
            Console.WriteLine();

            // traversal
            Console.WriteLine("traversal");
            // node is pointed at the first node in the list
            LinkedListNode<string> node = ll.First;
            while(node != null)
            {
                Console.WriteLine("    {0}", node.Value);
                // going to walk the nodes going Next, Next, Next
                node = node.Next;
            }
            Console.WriteLine();

        }

        public static void DisplayProperties(LinkedListNode<string> lln)
        {
            // looks at node I'm on and prints out count of linked list if there is 
            // a linkedlist existing to count
            if (lln.List == null)
                Console.WriteLine("    Node is not linked");
            else
                Console.WriteLine("    Node belongs to a linked list with {0} elements", lln.List.Count);

            // looks at previous node and tells it to print out the value if it's not null
            if (lln.Previous == null)
                Console.WriteLine("    Previous node is null");
            else
                Console.WriteLine("    Value of previous node: {0}", lln.Previous.Value);
            // looks ahead of the node I'm on and tells me what's ahead of me
            if (lln.Next == null)
                Console.WriteLine("    Next node is null");
            else
                Console.WriteLine("    Value of next node: {0}", lln.Next.Value);
        
        }
    }
}
