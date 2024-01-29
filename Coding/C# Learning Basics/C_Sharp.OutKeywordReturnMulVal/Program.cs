using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.OutKeywordReturnMulVal
{
    internal class Program
    {
        public void show(out int a, out int b)
        {
            int square = 5;
            a = square;
            b= square;

            a *= a;
            b*= b;
        }
        static void Main(string[] args)
        {
            int val1 = 50, val2 = 100;

            Program obj = new Program();
            Console.WriteLine("Value sbefore passing val1 = {0}, val2 = {1}", val1, val2);

            obj.show(out val1, out val2);
            Console.WriteLine("Value before passing val1 = {0}, val2 = {1}", val1, val2);
            Console.ReadLine();
        }
    }
}
