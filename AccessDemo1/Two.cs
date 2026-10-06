using System;
using System.Collections.Generic;
using System.Text;

namespace AccessDemo1
{
    internal class Two : One
    {
        static void Main()
        {
            Two t = new Two();
            //t.Test1(); // Not accessible because it's private in One
            t.Test2(); // Accessible because it's protected in One
            t.Test3(); // Accessible because it's internal in One
            t.Test4(); // Accessible because it's protected internal in One
            t.Test5(); // Accessible because it's public in One
        }
    }
}
