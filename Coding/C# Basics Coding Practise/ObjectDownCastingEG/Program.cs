using System;

namespace ObjectDownCastingEG{
    class Parent{
        public virtual void fun(){
            Console.WriteLine("Parents functionality");
        }
    }
     class Child: Parent{
        public override void fun(){
            Console.WriteLine("Child functionality");
        }
    }
    class Program{
        static void Main(string[] args){
            Child obj = new Parent();
            obj.fun();
        }
    }
}