using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.LinearSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int item = 0;
            int pos = 0;
            int[] arr = new int[5];
           
            Console.WriteLine("Enter elements : ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
          
            Console.Write("Enter item to search : ");
            item = int.Parse(Console.ReadLine());
            for (i = 0; i < arr.Length; i++)
            {
                if (item == arr[i])
                {
                    pos = i + 1;
                    break;
                }
            }
            if (pos == 0)
            {
                Console.WriteLine("Item Not found in array");
            }
            else
            {
                Console.WriteLine("Position of item in array:"+pos);
            }
        }
    }
}
