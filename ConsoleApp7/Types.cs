using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class TypeA
    {
        public int A { get; set; }
        public void Fun01()
        {
            Console.WriteLine("Fun01 from TypeA");
        }
        public virtual void Fun02()
        {
            Console.WriteLine($"{A}");
        }
    }
    class TypeB : TypeA
    {
        public int B { get; set; }
        public new void Fun01()
        {
            Console.WriteLine("Fun01 from TypeB");
        }
        public override void Fun02()
        {
            Console.WriteLine($"{A}, {B}");
        }
    }

    class TypeC : TypeB
    {
        public int C { get; set; }
        public new void Fun01()
        {
            Console.WriteLine("Fun01 from TypeC");
        }
        public override void Fun02()
        {
            Console.WriteLine($"{A}, {B}, {C}");
        }
    }

    class TypeD : TypeC
    {
        public int D { get; set; }
        public new void Fun01()
        {
            Console.WriteLine("Fun01 from TypeD");
        }
        public override void Fun02()
        {
            Console.WriteLine($"{A}, {B}, {C}, {D}");
        }
    }

}
