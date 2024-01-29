using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.AsyncAwaitEG
{
    internal class Program
    {
        public static async Task Method1()
        {
            await Task.Delay(7000);
            Console.WriteLine("Method1 Executed");
        }
        public static async Task Method2()
        {
            await Task.Delay(2000);
            Console.WriteLine("Method2 Executed");

        }
        public static async Task Method3()
        {
            await Task.Delay(8000);
            Console.WriteLine("Method3 Executed");
        }
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Task.WaitAll(Method1(), Method2(), Method3());

            stopwatch.Stop();

            var timeElapsed = stopwatch.ElapsedMilliseconds;
            Console.WriteLine("The time taken to  finish executing all three method is: "+ timeElapsed);
            Console.Read();

            //The time taken to  finish executing all three method is: 8030
        }
    }
}
