using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToCSharp
{
    public class Helper
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Helper(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Helper()
        {
            Id = 0;
            Name = string.Empty;
        }

        public void Data(string firstName,string lastName)
        {
            Console.WriteLine($"Fullname: {lastName + " " + firstName}");
        }
    }

  
}
