using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDelegateEG
{
    internal class Program
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            /*  
             * Func Delegate -  
             *  Its used when we need to pass a method as a paramater with a return value.
             */ 
            Func<int, int, int> add = Sum;
            int result = add(10, 10);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
