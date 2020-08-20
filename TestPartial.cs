using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToCSharp
{
    public partial class TestPartial
    {
        partial void Print();
        partial void Print()
        {
            Console.WriteLine("I am the Partial Method()");
        }
        public void Greetings()
        {
            Console.WriteLine("Good evening! the time check is " + DateTime.Now.ToShortTimeString());
            Print();
        }
    }
}
