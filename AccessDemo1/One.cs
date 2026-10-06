using System;
using System.Collections.Generic;
using System.Text;

namespace AccessDemo1
{
    public class One
    {
        private void Test1()
        {
            Console.WriteLine("Private Test1");
        }
        protected void Test2()
        {
            Console.WriteLine("Protected Test2");
        }
        internal void Test3()
        {
            Console.WriteLine("Internal Test3");
        }
        protected internal void Test4()
        {
            Console.WriteLine("Protected Internal Test4");
        }
        public void Test5()
        {
            Console.WriteLine("Public Test5");
        }
        static void Main()
        {
            One o = new One();
            o.Test1();
            o.Test2();
            o.Test3();
            o.Test4();
            o.Test5();
        }
    }
}
