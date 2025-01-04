using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Overriding
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }
        // override or hide
        // apply override:
        // 1. apply using "new" keyword  ==> defult
        // 2 apply using "override" keyword
        public new void Fun01() 
        {
            Console.WriteLine("fun01 type B");
        }
        //  must be not private and virtual
        // Dynamic binding : CLR will binf the function call based on object type not the reference type
        // Runtime
        public override void Fun02()
        {
            Console.WriteLine($"{A}, {B}");
        }
    }
}
