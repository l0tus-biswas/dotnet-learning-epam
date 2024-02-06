using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambaExpressionEG
{
    public class Student
    {
        public int rollNo { get; set; }
        public string name { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>
            {
                new Student { rollNo = 3, name = "Lotus"},
                new Student { rollNo = 2, name = "Himani"},
                new Student { rollNo = 1, name = "Rai"},
                new Student { rollNo = 4, name = "Raj"},
                new Student { rollNo = 5, name = "Ramesh"},
            };

            var student = list.OrderBy(x => x.rollNo);

            foreach(var s in student)
            {
                Console.WriteLine("RollNo: " + s.rollNo + " and " + "Name: " + s.name);
            }
            Console.Read();
        }
    }
}
