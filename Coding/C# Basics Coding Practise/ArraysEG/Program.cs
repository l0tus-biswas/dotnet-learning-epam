using System;

namespace ArraysEG{
    class Program{
       static void Main(string[] args){
        //  int[] arr = new int[5];

        // arr[0] = 10;
        // arr[1] = 20;
        // arr[2] = 30;

        // for(int i=0;i<arr.Length;i++){
        //     Console.WriteLine(arr[i]);
        // }

        // Declaring array by omiting the size of the array
        // int[] arr = new int[]{10,20,30,40, 0, 3};
        // Console.WriteLine(arr.Length);


        // Declaring array by initialing array at the time of declaration
        int[] arr = new int[10]{10,20,30,40,50,60};
        Console.WriteLine(arr.Length); // error as we have said the size is 10, but has only 6 elements.
            Console.WriteLine(arr[1]);
       
    }
}
}