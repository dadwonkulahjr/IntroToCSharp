using CustomLibery;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace IntroToCSharp
{
    class Program
    {

        static void Main()
        {
            CustomPartial customPartial = new CustomPartial(1, "Mark", "Smith");
            string fullName = customPartial.PrintInfo();
            Console.WriteLine($"Fullname: {fullName}");

            Console.ReadLine();
        }


    }
  
   
 
}




