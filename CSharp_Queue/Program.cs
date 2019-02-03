using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Start {nameof(CSharp_Queue)}");

            WorkWithQueue_1();

            WorkWithQueue_2();

            Console.WriteLine($"Complete {nameof(CSharp_Queue)}");
            Console.ReadKey();
        }

        private static void WorkWithQueue_2()
        {
            //When we want to  remove an element at the beginning of the collection and return it, we are going to use the Dequeue method:
            Queue queueCollection2 = new Queue();
            queueCollection2.Enqueue(54);
            queueCollection2.Enqueue("Teste");
            queueCollection2.Enqueue(54.10);

            int number = Convert.ToInt32(queueCollection2.Dequeue());
            Console.WriteLine($"Removed element is {number}");
            Console.WriteLine();

            foreach (var item in queueCollection2)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        private static void WorkWithQueue_1()
        {
            Queue<int> intCollection = new Queue<int>();

            //The Enqueue method adds an element inside a collection
            Queue queueCollection1 = new Queue();
            queueCollection1.Enqueue(54);
            queueCollection1.Enqueue("Teste");
            queueCollection1.Enqueue(54.10);

            foreach (var item in queueCollection1)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
