using System;
namespace InputEG
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            float salary;
            double cgpa;
            Console.WriteLine("Please enter your name - ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age - ");
            age =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your salary - ");
            salary = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter you college CGPA - ");
            cgpa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Name is {0} , age is {1} , salary is {2} and CGPA is {3}", name, age,  salary, cgpa);
        }
    }
}