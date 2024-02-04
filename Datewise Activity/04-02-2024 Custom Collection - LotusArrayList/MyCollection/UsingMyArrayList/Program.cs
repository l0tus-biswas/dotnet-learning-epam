using LotusArrayList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingMyArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LotusArrayList<int> list = new LotusArrayList<int>();

            
            Console.WriteLine("Using -- AddToBack(T value)");
            Console.WriteLine("Adding element one after another");
            list.AddToBack(10);
            list.AddToBack(20);
            list.AddToBack(30);

            list.Print();
            Console.WriteLine("\n");
            
           
            Console.WriteLine("Using -- AddToFront(T value)");
            Console.WriteLine("Adding element to front");
            list.AddToFront(9);
            list.AddToFront(8);
            list.AddToFront(7);

            list.Print();
            Console.WriteLine("\n");


            Console.WriteLine("Using -- RemoveByValue(T value)");
            Console.WriteLine("Removing element by value");
            list.RemoveByValue(8);
            list.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Using -- InsertAfterIndex(T value, int index)");
            Console.WriteLine("Adding 25 after 4 index ");
            list.InsertAfterIndex(25, 4);
            list.Print();
            Console.WriteLine("\n");


            Console.WriteLine("Using -- Contains(T value)");
            Console.WriteLine("Is element 20 in the list ?");
            bool res = list.Contains(20);
            Console.WriteLine(res);
            Console.WriteLine("\n");


            Console.WriteLine("Using -- ContainsWithPosition(T value)");
            Console.WriteLine("Is element 20 in the list, if there in which location ?");
            int pos = list.IndexOf(20);
            if(pos == -1)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine(pos);
            }
            Console.WriteLine("\n");



            Console.WriteLine("Using -- Count()");
            Console.WriteLine("Counting total elements in the list");
            int totalEle = list.Count();
            Console.WriteLine(totalEle);


            
            Console.Read();
        }
    }
}
