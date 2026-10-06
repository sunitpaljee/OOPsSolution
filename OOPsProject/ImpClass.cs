using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsProject
{
    internal class ImpClass : Interface1, Interface2
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void Div(int a, int b)
        {
            Console.WriteLine(a /b);
        }

        public void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void Main()
        {
            ImpClass c = new ImpClass();
            c.Add(1, 2);
            c.Sub(1, 2);
            c.Mul(1, 2);
            c.Div(1, 2);
            Interface1 i1 = c;
            i1.Add(100, 20);
            i1.Sub(100, 20);
            Interface2 i2 = c;
            i2.Mul(50, 5);
            i2.Div(50, 5);
        }
    }
}
