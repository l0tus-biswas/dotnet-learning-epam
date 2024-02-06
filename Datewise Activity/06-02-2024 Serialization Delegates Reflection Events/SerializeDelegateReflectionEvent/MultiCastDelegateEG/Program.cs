using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegateEG
{
    delegate void Calculator(int x, int y);
    internal class Program
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        public static void Mult(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        static void Main(string[] args)
        {
            Calculator cal = new Calculator(Add);


            // multi cast delegate
            // 600
            cal += Mult;

            // calling method using delegate
            cal(20, 30); // 50


            Console.Read();


        }
    }
}
