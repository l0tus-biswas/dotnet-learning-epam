using System;
namespace ProtectedAccessModifiersInChildClassEG{
    class A{
        protected string name = "Lotus Biswas";
        protected int salary = 12000;
        
        protected void msg(){
            Console.WriteLine("Name is {0} and salary is {1}", name, salary);
        }
        
    }
    class Program: A{
        static void Main(string[] args){
            Program obj = new Program();
            Console.WriteLine(obj.name);
            obj.msg();
        }
    }
}