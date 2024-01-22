using System;
namespace ThisKeywordEG{

    class Employee{
        int id; string name; float salary;

        public Employee(int id, string name, float salary){
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void welcome(){
            Console.WriteLine("WELCOME");
        }
        public void display(){
            this.welcome();
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", id, name, salary);
        }
    }
    class Program{
        static void Main(string[] args){
            Employee obj = new Employee(1, "Lotus Biswas", 45000);
            obj.display();
        }
    }
}