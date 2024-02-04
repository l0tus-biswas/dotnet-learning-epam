using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace C_Sharp.ArrayListEG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(43);
            al.Add(52);
            al.Add(12);
            al.Add(2);


            Console.WriteLine("Capaity: {0} ", al.Capacity);
        
            Console.WriteLine("Count: {0} ", al.Count);
            
            foreach(int i in al)
            {
                Console.Write(i + " ");
            }

            al.Sort();

            foreach(int i in al)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
            DateTime dt = Convert.ToDateTime("02/01/20000");
        }

    }
}
