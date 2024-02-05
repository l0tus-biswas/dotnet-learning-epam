using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentDictionaryEG
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ConcurrentDictionary<int, string> concurrentDict = new ConcurrentDictionary<int, string>();
            Parallel.For(0, 10, i =>
            {
                concurrentDict.TryAdd(i, $"Value {i}");
            });

            foreach( var item in concurrentDict )
            {
                Console.WriteLine ($"Key: {item.Key}, Value: {item.Value}");
            }

            Console.Read();

            /*
            Key: 0, Value: Value 0
            Key: 1, Value: Value 1
            Key: 2, Value: Value 2
            Key: 3, Value: Value 3
            Key: 4, Value: Value 4
            Key: 5, Value: Value 5
            Key: 6, Value: Value 6
            Key: 7, Value: Value 7
            Key: 8, Value: Value 8
            Key: 9, Value: Value 9
            */
        }
    }
}
