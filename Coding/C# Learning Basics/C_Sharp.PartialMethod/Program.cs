using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.PartialMethod
{
    partial class Program
    {
        partial void showMsg(string msg);

    }
    internal partial class Program
    {
        Program()
        {
            Console.WriteLine("Constrcutor called");
        }
        partial void showMsg(string msg)
        {
           Console.WriteLine(msg);
           Console.ReadLine();
        }
        static void Main(string[] args)
        {
           Program obj = new Program();
           obj.showMsg("welcome to lotus");
        }
    }
}
