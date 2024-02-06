using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateDelegateEG
{
    internal class Program
    {
        static bool IsUppercase(string s)
        {
            return s.Equals(s.ToUpper());
        }
        static void Main(string[] args)
        {
            /*
             * Predicate Delegate -
             * It is a specialized version of the Func delegate that represent a method
             * that takes a single input paramater and returns a boolean value. It is
             * commonly used for filtering or testing conditions.
             */

            Predicate<string> pred = IsUppercase;
            pred("ABC");

            Console.Read();
        }
    }
}
