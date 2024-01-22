using System;

namespace StringsEG{
    class Program{
        static void Main(string[] args){
            string outstr;
            string str1 = "Hi, this is Lotus Biswas";
            string str2 = "This is a string";
            string str3 = "THis iS A stRIng";
            string[] str = {"One", "Two", "Three", "Four"};

            // Length of a string
            Console.WriteLine(str1.Length);

            // Access individual characters
            Console.WriteLine(str1[2]);

            // Iterrate over a string like any other sequence of values
            foreach(char ch in str1){
                Console.Write(ch);
                if(ch == 'b' || ch == 'B'){
                    Console.WriteLine();
                    break;
                }
            }

            // String concatination
            outstr = String.Concat(str);
            Console.WriteLine(outstr);

            // Join strings
            outstr = String.Join(".", str);
            Console.WriteLine(outstr);

            outstr = String.Join("----", str);
            Console.WriteLine(outstr);

            /*
            TODO: String Comparison

            < 0 : first string comes before second in sort order
            0 : first and second strings are same postion in sort order
            > 0 : first string comes after the second in sort order

            */

            int result = String.Compare(str2, "This is a string");
            Console.WriteLine(result);

            bool isEqual = str2.Equals(str3);
            Console.WriteLine(isEqual);

            // STRING SEARCHING

            Console.WriteLine(str1.IndexOf('i'));
            Console.WriteLine(str1.IndexOf("is"));

            Console.WriteLine(str1.LastIndexOf('e'));
            Console.WriteLine(str1.LastIndexOf("as"));

            outstr = str1.Replace("as", "ca");
            Console.WriteLine(outstr);
            Console.WriteLine(outstr.IndexOf("as"));
            
        }
    }
}