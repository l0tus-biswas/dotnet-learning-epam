using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace C_Sharp.Synchronous
{
    internal class Program
    {
        public static void Method1()
        {
            Thread.Sleep(7000);
            Console.WriteLine("Method 1 Executed");
        }
        public static void Method2()
        {
            Thread.Sleep(3500);
            Console.WriteLine("Method 2 Executed");

        }
        public static void Method3()
        {
            Thread.Sleep(8000);
            Console.WriteLine("Method 3 Executed");

        }

        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Method1();
            Method2();
            Method3();
            stopwatch.Stop();

            var timeElasped = stopwatch.ElapsedMilliseconds;
            Console.WriteLine("Time taken to finish executed all three method is " + timeElasped);
            Console.Read();


            //Time taken to finish executed all three method is 18519
        }
    }
}
