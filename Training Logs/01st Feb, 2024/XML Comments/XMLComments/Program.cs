using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLComments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "10";
            s.ToInt(s);
        }
        
    }
    public static class StringExtension
    {
        public static int ToInt(this string ss, string s)
        {
            return Convert.ToInt32(s);
        }
    }
}
