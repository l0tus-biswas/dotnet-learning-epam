using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.LinkedListEG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> obj = new LinkedList<string>();
            obj.AddLast("Sonoo Jaiswal");
            obj.AddLast("Ankit");
            obj.AddLast("Peter");
            obj.AddLast("Irfan");

            foreach(string s in obj)
            {
                Console.WriteLine(s);   
            }

            Console.Read();
        }
    }
}
