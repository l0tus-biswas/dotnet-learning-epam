using System;

namespace BoxingAndUnboxingEG{
    class Program{
        static void Main(string[] args){
            int num =23;
            
            // boxing - value type of object type
            object obj = num;

            // unboxing - object type to value
            int i = (int)obj;

            Console.WriteLine("Value of obj object is : " + obj);
            Console.WriteLine("Value of i is : "+ i);
        }
    }
}