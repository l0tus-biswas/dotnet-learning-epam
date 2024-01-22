using System;
namespace EncapsulationEG{
    class Employee{
        private int num;
        private string name;
        private double salary;

        public void setNum(int num){
            this.num = num;
        }
        public int getNum(){
            return this.num;;
        }
        public void setName(string name){
            this.name = name;
        }
        public string getName(){
            return this.name;
        }
         public void setSalary(double salary){
            this.salary = salary;
        }
        public double getSalary(){
            return this.salary;
        }
    }
    class Program{
        public static void Main(string[] args){
            Employee obj= new Employee();
            obj.setNum(101);
            obj.setName("Lotus Biswas");
            obj.setSalary(4500);
            Console.WriteLine(obj.getNum());
            Console.WriteLine(obj.getName());
            Console.WriteLine(obj.getSalary());
        }

    }
}