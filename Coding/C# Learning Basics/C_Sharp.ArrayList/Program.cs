using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace C_Sharp.ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("Adding some numbers:");

            al.Add(45);
            al.Add(78);
            al.Add(1);

            Console.WriteLine("Capacity: {0}", al.Capacity);

        }
    }
}
