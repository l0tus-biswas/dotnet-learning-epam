using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentStackEG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcurrentStack<int> obj = new ConcurrentStack<int>();
            obj.Push(1);
            obj.Push(2);
            obj.Push(3);

            

        }
    }
}
