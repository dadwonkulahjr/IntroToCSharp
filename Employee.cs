using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToCSharp
{

    public delegate void MulticastDelegate(out int number);
    public class Employee
    {
        public void SimpleMethodOne(out int value)
        {
            value = 1;
        }
        public void SimpleMethodTwo(out int value)
        {
            value = 2;
          
        }
        public void SimpleMethodThree(out int value)
        {
            value = 3;
        }

    }
}
