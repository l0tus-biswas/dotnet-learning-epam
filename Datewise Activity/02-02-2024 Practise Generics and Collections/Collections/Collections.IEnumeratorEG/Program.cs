using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.IEnumeratorEG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            myList.Add("Apple");
            myList.Add("Banana");
            myList.Add("Orange");

            IEnumerator enumartor = myList.GetEnumerator();
            while(enumartor.MoveNext())
            {
                object currentElement = enumartor.Current;
                Console.WriteLine(currentElement);
            }

            Console.Read();
        }
    }
}
