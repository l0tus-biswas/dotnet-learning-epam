using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializationEG
{
    [Serializable]
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { Name = "John", Age = 30 };
            BinaryFormatter formatter = new BinaryFormatter();

            // Serialize object to a file
            using (FileStream stream = new FileStream("person.bin", FileMode.Create))
            {
                formatter.Serialize(stream, person);
            }

            // Deserialize object from file
            using (FileStream stream = new FileStream("person.bin", FileMode.Open))
            {
                Person deserializedPerson = (Person)formatter.Deserialize(stream);
                Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
            }
            Console.ReadLine();
        }
    }
}
