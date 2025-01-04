using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Inheritence
{
    internal class Child : Parent
    {
        public int Z { get; set; }
        public Child(int X, int Y, int Z) : base(X,Y)
        {
            this.Z = Z;
        }
        public override string ToString()
        {
            return $"{X}, {Y}, {Z}";
        }

        public void Fun01()
        {
            Console.WriteLine("I'm child");
        }
        public void Fun02()
        {
            Console.WriteLine($"{X} , {Y} {Z}");
        }


    }
}
