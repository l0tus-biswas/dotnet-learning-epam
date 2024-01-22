using System;
namespace PublicAccessModifersEG{

    class A{
        public string name = "Lotus Biswas";
        public void methodMsg(string msg){
            Console.WriteLine("Hello " + msg);
        }
    }
    class Program{
        public static void Main(string[] args){
            A obj = new A();
            Console.WriteLine("Hello " + obj.name);
            obj.methodMsg("Lotus Biswas");
        }
    }
}