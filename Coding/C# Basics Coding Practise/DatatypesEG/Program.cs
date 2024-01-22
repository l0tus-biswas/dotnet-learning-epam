using System;

namespace DatatypesEG
{
    class Program
    {
        static void Main(string[] args)
        {
              //ushort
            ushort e = 18910;
            Console.WriteLine("ushort...");
            Console.WriteLine("e = " + e);
            Console.WriteLine("type of variable = " + e.GetType());
            Console.WriteLine("size of ushort = " + sizeof(short));
            Console.WriteLine("Min value of ushort = " +  ushort.MinValue);
            Console.WriteLine("Max value of ushort = " +  ushort.MaxValue);
            Console.WriteLine();

        }
    }
}