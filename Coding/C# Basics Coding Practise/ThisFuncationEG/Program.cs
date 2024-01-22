using System;

namespace ThisFuncationEG{
  
  public class Test{
    public Test(): this(10){
        Console.WriteLine("Zero args");
    }
    public Test(int x): this(10,20){
        Console.WriteLine("Args");
    }
    public Test(int x, int y){
        Console.WriteLine("Two args");
    }
  }

    class Program{
        static void Main(string[] args){
            Test obj = new Test();
        }
    }
}