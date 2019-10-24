using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            // stacks
            // declaration
            // this is an emptpy stack
            Stack<Student> stackOfStudents = new Stack<Student>();

            // initialize
            // push objects onto stack
            stackOfStudents.Push(new Student("Bill"));
            stackOfStudents.Push(new Student("Jill"));
            stackOfStudents.Push(new Student("Jack"));

            // traversal
            foreach(Student s in stackOfStudents)
            {
                // call the property to get the name out
                Console.WriteLine(s.Name);
            }
            Console.WriteLine(stackOfStudents.Count + "\n");

            // pops
            // count changes as you pop items off

            // variable to hold original size
            int size = stackOfStudents.Count;

            for (int i =0; i<size; i++)
            {
                //call the name property to print out as you pop elements off
                Console.WriteLine(stackOfStudents.Pop().Name);
            }
            Console.WriteLine(stackOfStudents.Count + "\n");

            // queues
            Queue<Student> studentQueue = new Queue<Student>();

            // put items into queue
            studentQueue.Enqueue(new Student("Bill"));
            studentQueue.Enqueue(new Student("Jill"));
            studentQueue.Enqueue(new Student("Jack"));

            // traversal
            foreach(Student s in studentQueue)
            {
                Console.WriteLine(s.Name);
            }

            Console.WriteLine(studentQueue.Count + "\n");

            size = studentQueue.Count;

            for (int i=0; i<size; i++)
            {
                Console.WriteLine(studentQueue.Dequeue().Name);
            }
            Console.WriteLine(studentQueue.Count + "\n");
        }
    }
}
