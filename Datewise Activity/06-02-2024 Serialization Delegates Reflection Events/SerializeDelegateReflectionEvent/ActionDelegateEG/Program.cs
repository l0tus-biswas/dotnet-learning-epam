using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegateEG
{
    internal class Program
    {
        static void Sum(int a , int b)
        {
            Console.WriteLine(a + b);
        }

        static void Main(string[] args)
        {

            /*
             * Action Delegate -
             * It is a predefined delegate type in C# that represents a method with no
             * return value. It is used when we want to pass a method as a parameter 
             * without a return value
             */ 

            Action <int,int> add = Sum;
            add(10, 20);
            Console.Read();
        }
    }
}
