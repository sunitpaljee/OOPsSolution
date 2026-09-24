using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsProject
{
    internal class AbsChild : AbsParent
    {
        public override int Div(int a, int b)
        {
            return a / b;
        }

        public override int Mul(int a, int b)
        {
            return a * b;
        }
        static void Main()
        {
            AbsChild child = new AbsChild();
            child.Add(20, 10);
            Console.WriteLine(child.Sub(20, 10));
            Console.WriteLine(child.Mul(20, 10));
            Console.WriteLine(child.Div(20, 10));
            
        }
    }
}
