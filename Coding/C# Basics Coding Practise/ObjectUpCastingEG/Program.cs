using System;

namespace ObjectUpCastingEG{
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
            Parent obj = new Child();
            obj.fun();
        }
    }
}