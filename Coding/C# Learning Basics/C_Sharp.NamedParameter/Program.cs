﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.NamedParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Normal Way
            Add(10, 20.1, 20.2, 20.3);

            // Named Parameter
            Add(a: 20.1, b: 20.2, c: 20.3, x: 10);
            Console.Read();
        }
        public static void Add(int x, double a, double b, double c)
        {
            Console.WriteLine(x + a + b + c);
        }
    }
}
