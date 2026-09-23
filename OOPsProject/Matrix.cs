using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace OOPsProject
{
    public class Matrix
    {
        int a, b, c, d;
        public Matrix(int a, int b, int c, int d)
        {
            this.a = a; this.b = b; this.c = c; this.d = d;
        }
        public static Matrix operator + (Matrix m1, Matrix m2)
        {
            return m1 + m2;   
        }
        public static Matrix operator - (Matrix m1, Matrix m2)
        {
            return m1 - m2;
        }
        public static void Main(string[] args)
        {
            Matrix m1 = new Matrix(9, 5, 3, 8);
            Matrix m2 = new Matrix(1, 3, 4, 2);
            Matrix m3 = new Matrix(m1.a+m2.a, m1.b+m2.b, m1.c+m2.c, m1.d+m2.d);
            Matrix m4 = new Matrix(m1.a -m2.a, m1.b -m2.b,m1.c-m2.c, m1.d-m2.d);
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);

            StringBuilder sb = new StringBuilder();
            sb.Append("Swati ");
            sb.Append(10);
            sb.Append("Muizun ");
            sb.Append("Aman ");
            sb.Append("Manas");
            Console.WriteLine(sb);
        }
        public override string ToString()
        {
            return a + " " + b + "\n" + c + " " + d + "\n";
        }
    }
}
