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
            public virtual void Method2()
            {
                Console.WriteLine("Parent2!");
            }
        }
        class Child : Parent
        {
            public new string variable = "shadowing";
            public new void Method()
            {
                Console.WriteLine("Child!");
            }
            public override void Method2()
            {
                Console.WriteLine("Child2!");
            }
        }
        static void Main(string[] args)
        {
            Child child = new Child();
            Console.WriteLine(child.variable);
            Console.WriteLine("Child variable : " + child.variable);
            Console.WriteLine("Parent variable : " + ((Parent)child).variable);
            
            Console.WriteLine("하이딩");
            child.Method();
            ((Parent)child).Method();

            Console.WriteLine("오버라이딩");
            child.Method2();
            ((Parent)child).Method2();

        }
    }
}
