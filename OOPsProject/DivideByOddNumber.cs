using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsProject
{
    public class DivideByOddNumber : Exception
    {
        public DivideByOddNumber()
        {
            
        }
        //public override string Message => base.Message;

        public override string Message
        {
            get
            {
                return "Sunit";
            }
        }
    }
}
