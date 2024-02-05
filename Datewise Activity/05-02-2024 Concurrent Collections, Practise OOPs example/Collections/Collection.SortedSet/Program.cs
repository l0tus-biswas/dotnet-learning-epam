using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.SortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> obj = new SortedSet<string>(); ;
            obj.Add("Sonno");
            obj.Add("Ankit");
            obj.Add("Peter");
            obj.Add("Irfan");
            obj.Add("Ankit");

            foreach (string s in obj)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
