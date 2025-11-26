using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        //calls the method Quit with the NotImplementedException because I don't know what to add and that's all the submission wants
        public void Quit()
        {
            throw new NotImplementedException();
        }
    }
}
