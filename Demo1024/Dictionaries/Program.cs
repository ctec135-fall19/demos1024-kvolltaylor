using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaration
            // <type key, type value>
            Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>();

            // initialize
            studentDictionary.Add("Bill", new Student("Bill1"));
            // stepping into order using key as the index
            // here you can create key/value pair to add to dictionary without knowing
            // the key first like you would have to know the index position first
            studentDictionary["Jill"] = new Student("Jill2");
            studentDictionary["Jack"] = new Student("Jack3");

            // traversal
            // can traverse the keys or traverse the values independently
            foreach(string key in studentDictionary.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();
            foreach (Student s in studentDictionary.Values)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();



        }
    }
}
