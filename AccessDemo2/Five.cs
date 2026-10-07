using System;
using System.Collections.Generic;
using System.Text;

namespace AccessDemo2
{
    internal class Five
    {
        static void Main()
        {
           Five f = new Five();
            //five.AddNums(5, 10);
            //five.SayHello("Hello, World!");
            //AddDel addDel = new AddDel(f.AddNums);
            //addDel(5, 10);
            
            //SayDel sayDel = new SayDel(f.SayHello);
            //sayDel("Hello, World!");

            //AddDel addDel1 = new AddDel(Five.AddNumsStatic);
            //addDel1(5, 10);

            MathDel mathDel = f.AddNums;
            mathDel += f.SubNums;
            mathDel += f.MultNums;
            mathDel += f.DivNums;
            
            mathDel(10, 5);

        }
        public void AddNums( int a, int b )
        {
            Console.WriteLine(a + b);
        }
        public void SubNums(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void MultNums(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public void DivNums(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        public void SayHello(string message)
        {
            Console.WriteLine(message);
        }
        public static void AddNumsStatic(int a, int b)
        {
            Console.WriteLine(a + b);
        }

    }
}
