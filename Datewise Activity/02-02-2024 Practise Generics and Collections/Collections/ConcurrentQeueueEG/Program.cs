using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentQeueueEG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcurrentQueue<int> concurrentQueue = new ConcurrentQueue<int>();
            Parallel.For(0, 10, i =>
            {
                concurrentQueue.Enqueue(i);
            });

            Parallel.ForEach(concurrentQueue, item =>
            {
                Console.WriteLine($"Dequeue: {item}");
            });
            Console.ReadLine();
        }
    }
}
