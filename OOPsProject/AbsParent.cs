using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsProject
{
    internal abstract class AbsParent
    {
        //public int Add(int a, int b)
        //{
        //    return a + b;
        //}
        //public int Sub(int a, int b)
        //{
        //    return a - b;
        //}

        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public abstract int Mul(int a, int b);
        public abstract int Div(int a, int b);
    }
}
