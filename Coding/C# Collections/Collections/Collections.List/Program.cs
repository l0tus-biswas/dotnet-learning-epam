using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            names.Add("a");
            names.Add("b");

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
