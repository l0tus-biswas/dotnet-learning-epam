using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionEG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get Type

            int a = 10;
            Type type = a.GetType();
            Console.WriteLine(type); // System.Int32


            // Get Assembly
            
            Console.WriteLine(type.S);
            Console.Read(); 
        }
    }
}
