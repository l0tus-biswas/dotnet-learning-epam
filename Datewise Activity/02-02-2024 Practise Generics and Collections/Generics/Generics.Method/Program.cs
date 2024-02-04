using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Method
{
    class GenericClass
    {
        public void show<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericClass obj = new GenericClass();
            obj.show("This is a generic method");
            obj.show(101);
            obj.show('O');

            Console.Read();
        }
    }
}
