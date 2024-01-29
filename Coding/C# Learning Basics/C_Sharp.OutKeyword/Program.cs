using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.OutKeyword
{
    internal class Program
    {
      public void show(out int val)
        {
            int square = 5;
            val = square;
            val *= val;
        }
        static void Main(string[] args)
        {
            int val = 5;
            Program obj = new Program();
            Console.WriteLine("Value before passing out varibale "+ val);
            obj.show(out val);
            Console.WriteLine("Value before passing out varibale " + val);
            Console.ReadLine();
        }
    }
}
