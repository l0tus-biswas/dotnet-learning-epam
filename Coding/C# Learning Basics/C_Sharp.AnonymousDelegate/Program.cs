using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.AnonymousDelegate
{
    public delegate void Calculator(int x, int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calcAdd = delegate (int a, int b)
            {
                Console.WriteLine(a + b);
            };
            calcAdd(10,20);
        }
    }
}
