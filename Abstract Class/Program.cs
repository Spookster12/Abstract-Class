using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee bob = new Employee() { firstName = "Sample", lastName = "Student" };
            bob.SayName();
            Console.ReadLine();
        }
    }
}
