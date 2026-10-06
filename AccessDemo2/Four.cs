using System;
using System.Collections.Generic;
using System.Text;

namespace AccessDemo2
{
    internal class Four : AccessDemo1.One
    {
        static void Main()
        {
            Four f = new Four();
            // f.Test1(); // Error: 'One.Test1()' is inaccessible due to its protection level
             f.Test2(); // Error: 'One.Test2()' is inaccessible due to its protection level
           // f.Test3(); // Accessible: Internal method
            f.Test4(); // Accessible: Protected internal method
            f.Test5(); // Accessible: Public method
        }
    }
}
