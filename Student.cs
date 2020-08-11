using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToCSharp
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"FirstName: {FirstName} - LastName: {LastName}");
        }
    }
}
