using MathFunctionDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDOTNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 18;
            int y = 3;

            Console.WriteLine("Making my own DLL and adding it as a reference to a console project :");

            int divResult = MathService.Divide(x, y);
            Console.WriteLine(x + " / " + y + " = " + divResult);

            int addResult = MathService.Add(x, y);
            Console.WriteLine(x + " + " + y + " = " + addResult);

            int subResult = MathService.Substract(x, y);
            Console.WriteLine(x + " + " + y + " = " + subResult);

            int multResult = MathService.Multiply(x, y);
            Console.WriteLine(x + " * " + y + " = " + multResult);

            Console.ReadLine();


        }
    }
}
