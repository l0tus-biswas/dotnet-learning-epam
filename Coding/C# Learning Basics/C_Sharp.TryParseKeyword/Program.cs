using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.TryParseKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            bool b = int.TryParse("10s", out i);

            String s = "10";
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
