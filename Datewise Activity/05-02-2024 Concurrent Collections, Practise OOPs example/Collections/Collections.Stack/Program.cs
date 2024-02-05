using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Stack follows LIFO. It can have duplicate elment. 

            Stack<string> obj = new Stack<string>();
            obj.Push("Sonno");
            obj.Push("Ankit");
            obj.Push("Peter");
            obj.Push("Irfan");

            foreach(string s in obj)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Peek element " + obj.Peek()); // Irfan
            Console.WriteLine("Pop " + obj.Pop()); // Irfan
            Console.WriteLine("After Pop, peek element: " + obj.Peek()); // Peter

            Console.Read();
        }
    }
}
