using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.ParamsKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = Add(10, 20, 30, 40, 50, 50);
            Console.WriteLine(sum);
            Console.WriteLine(AddByArr(new int[] {10,20,30,40,50,60 }));
            Console.ReadLine();
        }
        public static int Add(params int[] numbers)
        {
            int total = 0;
            foreach(int i in numbers)
            {
                total += i;
            }
            return total;
        }
        public static int AddByArr(int[] arr)
        {
            int sum = 0; 
            foreach(int i in arr)
            {
                sum += i;
            }
            return sum;
        }
    }
}
