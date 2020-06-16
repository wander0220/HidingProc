using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingProc
{
    class Program
    {
        class Parent
        {
            public int variable = 273;
            public void Method()
            {
                Console.WriteLine("Parent!");
            }
        }
        class Child : Parent
        {
            public new string variable = "shadowing";
            public new void Method()
            {
                Console.WriteLine("Child!");
            }
        }
        static void Main(string[] args)
        {
            Child child = new Child();
            Console.WriteLine(child.variable);
            Console.WriteLine("Child variable : " + child.variable);
            Console.WriteLine("Parent variable : " + ((Parent)child).variable);
            child.Method();
            ((Parent)child).Method();
        }
    }
}
