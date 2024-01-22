using System;
namespace ClassAndObjects
{
    class Program
    {
        int id; // field or data member
        string name; // field or data member
        public static void Main(string[] args)
        {
            Program obj = new Program();
            obj.id = 1;
            obj.name = "Lotus Biswas";

            // Corrected to use obj.name and obj.id
            Console.Write("Your name is {0} and your ID is {1}", obj.name, obj.id);

        }
    }
}