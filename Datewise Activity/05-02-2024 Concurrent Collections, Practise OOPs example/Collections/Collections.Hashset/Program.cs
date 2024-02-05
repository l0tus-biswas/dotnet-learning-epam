using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Hashset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> obj = new HashSet<string>();
            obj.Add("Sonoo");
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
