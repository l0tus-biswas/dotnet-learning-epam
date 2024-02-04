using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.BianrySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int item = 0;
            int pos = 0;
            int[] arr = new int[5];

            int LOW = 0;
            int HIGH = 0;
            int MID = 0;
           
            Console.WriteLine("Enter elements : ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter item to search : ");
            item = int.Parse(Console.ReadLine());
            HIGH = arr.Length - 1;
            MID = (LOW + HIGH) / 2;
         
            while (LOW <= HIGH)
            {
                if (item < arr[MID])
                {
                    HIGH = MID - 1;
                    MID = (LOW + HIGH) / 2;
                }
                else if (item > arr[MID])
                {
                    LOW = MID + 1;
                    MID = (LOW + HIGH) / 2;
                }
                else if (item == arr[MID])
                {
                    pos = MID + 1;
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
            Console.ReadLine();
        }
    }
}
    
