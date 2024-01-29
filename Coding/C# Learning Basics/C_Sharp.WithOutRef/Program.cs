using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.WithOutRef
{
    public class WithOutRef
    {
        int id = 1;
        string name = "lotus"; 
        public int update(out int c, ref int d)
        {
            c = 100;
            return c + d;
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b = 5;
            WithOutRef obj = new WithOutRef();
            int val = obj.update(out a, ref b);
            Console.WriteLine(val);
            Console.ReadLine();
        }
    }
}
