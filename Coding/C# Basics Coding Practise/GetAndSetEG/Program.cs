using System;

namespace GetAndSetEG{
    class Person{
        private string name;
        public string Name{
            get{ return name;}
            set{name = value;}
        }
    }
    class Program{
        static void Main(string[] arg){
            Person obj = new Person();
            obj.Name = "Lotus Biswas";
            Console.WriteLine("Name is {0}", obj.Name);
        }
    }
}