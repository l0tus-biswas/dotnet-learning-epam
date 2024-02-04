using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.OptionalParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddOptional(10,20);
            AddOptional(20,20,30);
            Console.Read();
        }
        public static void AddOptional(int i, int j, int k = 10)
        {
            Console.WriteLine(i + j + k);
        }
    }
}
