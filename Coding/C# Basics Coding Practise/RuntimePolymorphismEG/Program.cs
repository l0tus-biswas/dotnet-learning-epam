using System;
namespace RuntimePolymorphismEG{
    class Parent{
        public virtual void behave(){
            Console.WriteLine("Parent behaviour");
        }
    }
    class Child: Parent{
        public override void behave(){
            Console.WriteLine("Child behaviour");
        }
        public void behaviour(){
            base.behave();
            this.behave();
        }
    }
    public class Program{
        static void Main(string[] args){
            Child child = new Child();
            child.behaviour();
        }
    }
}