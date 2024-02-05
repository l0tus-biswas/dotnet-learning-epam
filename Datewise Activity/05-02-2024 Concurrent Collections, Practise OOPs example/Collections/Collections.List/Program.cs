using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = new List<int>();
            firstList.Add(1);
            firstList.Add(2);
            firstList.Add(3);

            Console.WriteLine("Capacity is: " + firstList.Capacity);
            Console.WriteLine("Count is: " + firstList.Count);

            firstList.Add(5);
            firstList.Add(6);

            Console.WriteLine("Capacity is: " + firstList.Capacity);
            Console.WriteLine("Count is: " + firstList.Count);

            Console.ReadLine();
        }
    }
}
