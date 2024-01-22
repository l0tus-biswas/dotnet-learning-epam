using System;
namespace SingleLevelInheritanceEG{
    class A{
        public void methodA(){
            Console.WriteLine("Method in A");
        }
    }
    class B: A{
        public void methodB(){
            Console.WriteLine("Method in B");
        }
    }
    class Program{
        static void Main(string[] args){
            B obj =  new B();
            obj.methodA();
            obj.methodB();
        }
    }
}