using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerializationEG
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { Name = "John", Age = 10 };

            XmlSerializer serializer = new XmlSerializer(typeof(Person));

            // Serialize object to a file
            using (FileStream stream = new FileStream("person.xml", FileMode.Create))
            {
                serializer.Serialize(stream, person);
            }

            // Deserialize object from file

            using(FileStream stream = new FileStream("person.xml", FileMode.Open))
            {
                Person deserializedPerson = (Person)serializer.Deserialize(stream);
                Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
            }

            Console.ReadLine();
        }
    }
}
