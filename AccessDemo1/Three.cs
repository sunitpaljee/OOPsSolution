using System;
using System.Collections.Generic;
using System.Text;

namespace AccessDemo1
{
    internal class Three
    {
     static void Main()
        {
            One o = new One();
            // o.Test1(); // Error: 'One.Test1()' is inaccessible due to its protection level
            // o.Test2(); // Error: 'One.Test2()' is inaccessible due to its protection level
            o.Test3(); // Accessible: Internal method
            o.Test4(); // Accessible: Protected internal method
            o.Test5(); // Accessible: Public method
        }
    }
}
