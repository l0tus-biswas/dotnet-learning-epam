using System;
namespace StructEG{

    public struct Rectange{
        public int width, height;
    }
    class Program{
        static void Main(string[] args){
            Rectange r = new Rectange();
            r.width = 4;
            r.height = 5;

            Console.WriteLine("Area of Rectange is " + (r.width * r.height));
        }
    }
}