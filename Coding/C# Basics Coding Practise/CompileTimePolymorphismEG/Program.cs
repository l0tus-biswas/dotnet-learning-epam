using System;
namespace CompileTimePolymorphismEG{
    class Calculator{
        public void add(int x, int y){
            int sum = x+y;
            Console.WriteLine("Sum of 2 number is "+ sum);
        }
         public void add(int x, int y, int z){
            int sum = x+y+z;
            Console.WriteLine("Sum of 3 number is "+ sum);
        }
    }
    class Program{
        static void Main(string[] args){
            Calculator obj = new Calculator();
            obj.add(10,20);
            obj.add(10,20,30);
        }
    }
}