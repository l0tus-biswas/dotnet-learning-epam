using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Lotus Biswas";
            Console.WriteLine("My Name is : "+ myName);
            Console.WriteLine(myName[0]); // L
            Console.WriteLine(myName.Length); // 12

            Console.WriteLine(myName.IndexOf('B')); // 6
            Console.WriteLine(myName.IndexOf('o')); // 1

            Console.WriteLine(myName.LastIndexOf('s')); // 11

            Console.WriteLine(myName.ToLower()); // lotus biswas
            Console.WriteLine(myName.ToUpper()); // LOTUS BISWAS
            Console.WriteLine(myName.StartsWith("Lotus")); // True
            Console.WriteLine(myName.Contains("swas")); // True
            Console.WriteLine(myName.Equals("Lotus Biswas")); // True
            Console.WriteLine(myName.Equals("lotus biswas")); // False (also checks for case)
            Console.WriteLine(myName.Equals("lotus biswas", StringComparison.OrdinalIgnoreCase)); // True (ignores case, checks only value)
            Console.Read();
        }
    }
}
