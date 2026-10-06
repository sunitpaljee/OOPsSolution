using System;
using System.Collections.Generic;
using System.Text;

namespace AccessDemo2
{
    internal class Five
    {
        static void Main()
        {
            AccessDemo1.One o = new AccessDemo1.One();
            // o.Test1(); // Error: 'One.Test1()' is inaccessible due to its protection level
            // o.Test2(); // Error: 'One.Test2()' is inaccessible due to its protection level
            // o.Test3(); // Error: 'One.Test3()' is inaccessible due to its protection level
            // o.Test4(); // Error: 'One.Test4()' is inaccessible due to its protection level
            o.Test5(); // Accessible: Public method
        }
    }
}
