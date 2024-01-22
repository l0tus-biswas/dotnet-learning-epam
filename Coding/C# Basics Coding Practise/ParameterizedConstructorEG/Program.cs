using System;

namespace ParameterizedConstructorEG
{
    class Employee{
        int id;
        string name;
        float salary;
        
        public Employee(int i, string n, float s){
            id = i;
            name = n;
            salary = s;
        }
        public void display(){
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", id, name, salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Employee obj = new Employee(1, "Lotus Biswas", 45000);
           obj.display();

        //    ID = 1, Name = Lotus Biswas, Salary = 45000

        }
    }

}