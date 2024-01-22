using System;

namespace ArrayUsingForeachLoopEG{
    class Program{
        static void Main(string[] args){
            int[] arr = new int[]{10,20,30,40,50};

            foreach(int i in arr){
                Console.WriteLine(i);
            }
        }
    }
}