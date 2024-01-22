using System;

namespace MultiLevelInheritanceEG{
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
    class C: B{
        public void methodC(){
            Console.WriteLine("Method in C");
        }
    }
    class Program{
        static void Main(string[] args){
            C obj = new C();
            obj.methodA();
            obj.methodB();
            obj.methodC();
        }
    }
}