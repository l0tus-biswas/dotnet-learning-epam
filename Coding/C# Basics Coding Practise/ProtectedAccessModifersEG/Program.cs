using System;
namespace ProtectedAccessModifersEG{
    class A{
        protected string name = "Lotus Biswas";
        protected int salary = 35000;

        protected void methodMsg(){
            Console.WriteLine("Name is {0} and salary is {1}", name, salary);
        }
    }
 
    class Program{
        static void Main(string[] args){
           A obj = new A();
           Console.WriteLine("Name is {0}", obj.name);
           obj.methodMsg();
        }
    }
}