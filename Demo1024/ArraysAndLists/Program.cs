using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // arrays
            // declaration
            int[] a1 = new int[5];

            // initialization and traversal
            // in order to access and travel you need an index
            // use Length not a literal number
            for(int i=0; i<a1.Length; i++)
            {
                a1[i] = (i * 10) + 1;
            }

            // new isn't required doing it this way, the compiler understands
            int[] a2 = { 1, 2, 3, 4, 5 };

            // traversal
            // in a foreach loop it traverses the array
            // it can only read the elements it can't change them
            foreach(int element in a1)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            // lists
            // declaration
            // T is the parameterization ofthe type you want
            // declared a variable l, is a generic list of ints
            List<int> l = new List<int>();

            // initialization
            l.Add(1);
            l.Add(2);
            l.Add(3);

            // element access
            // must have an index number to access
            // must use an index position within the List's range of indexes
            l[1] = 22;

            // some other methods
            // can insert into the middle, but not after last element bc
            // that would be out of bounds
            l.Insert(2, 99);
            // remove takes out element and then updates the indexes
            l.Remove(1);
            // built in sort, but you can define your own sort method
            l.Sort();

            // traversal
            // using for loop
            for(int i=0; i<l.Count; i++)
            {
                Console.WriteLine(l[i]);
            }
            // using foreach loop
            foreach(int element in l)
            {
                Console.WriteLine(element);
            }
        }
    }
}
