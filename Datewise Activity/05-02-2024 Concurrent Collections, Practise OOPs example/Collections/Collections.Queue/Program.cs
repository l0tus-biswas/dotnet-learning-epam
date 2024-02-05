using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Follows FIFO. It can have duplicate elements. 
           
            Queue<string> obj = new Queue<string>();
            obj.Enqueue("Sonno");
            obj.Enqueue("Ankit");
            obj.Enqueue("Peter");
            obj.Enqueue("Irfan");

            foreach(string s in obj)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Peek element : " + obj.Peek()); // Sonno
            Console.WriteLine("Dequeue : " + obj.Dequeue()); // Sonno
            Console.WriteLine("After dequeue, peek element : " + obj.Peek()); // Ankit

            Console.Read();
        }
    }
}
