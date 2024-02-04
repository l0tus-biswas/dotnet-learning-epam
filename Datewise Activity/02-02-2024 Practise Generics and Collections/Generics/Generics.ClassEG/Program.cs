using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.ClassEG
{
    class GenericsClass<T>
    {
        public GenericsClass(T msg)
        {
            Console.WriteLine(msg);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericsClass<string> genString = new GenericsClass<string>("This is generic class");
            GenericsClass<int> genInt = new GenericsClass<int>(101);
            GenericsClass<char> getChar = new GenericsClass<char>('O');

            Console.Read();
       
        }
    }
}
