using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Binding
{
    // for common property
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string Address { get; set; }
        public void Fun01()
        {
            Console.WriteLine("I'm employee");

        }
        public virtual void Fun02()
        {
            Console.WriteLine($"salary: ?");
        }
    }
}
