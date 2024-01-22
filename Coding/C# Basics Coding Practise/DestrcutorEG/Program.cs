using System;
namespace DestrcutorEG{
    class A{
        public A(){
            Console.WriteLine("Constructor called of A");
        }
        ~A(){
            Console.WriteLine("Destrctor called of A");
        }
    }
    class Program{
        static void Main(string[] args){
            A obj1 = new A();
            A obj2 = new A();
        }
    }
}