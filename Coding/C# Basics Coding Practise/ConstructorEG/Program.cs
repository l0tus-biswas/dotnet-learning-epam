using System;

namespace ConstructorEG
{
    class Program
    {
        public Program()
        {
            Console.WriteLine("Default Constructor called");
        }

        static void Main(string[] args)
        {
            Program obj1 = new Program();
            Program obj2 = new Program();

        }
    }

}