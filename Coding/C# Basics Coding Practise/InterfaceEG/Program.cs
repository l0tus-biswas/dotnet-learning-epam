using System;
namespace InterfaceEG{

    interface IAnimal{
        void animalSound();
    }

    class Pig: IAnimal{
        public void animalSound(){
            Console.WriteLine("The Pig says: wee wee");
        }
    }

    class Program{
        static void Main(string[] args){
            Pig obj = new Pig();
            obj.animalSound();
        }
    }
}