using System;
namespace MultipleInhertianceUsingInterface{
    public interface IA{
        void MethodA();
    }
    public class IB: IA{
        public void MethodA(){
                Console.WriteLine("Method call from IB");
        }
    }
    public class IC: IA{
        public void MethodA(){
                Console.WriteLine("Method call from IC");
        }
    }
    class Program{
        static void Main(string[] args){
           IA obj;
           obj = new IB();
           obj.MethodA();

           obj = new IC();
           obj.MethodA();
        }
    }
}