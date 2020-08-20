using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToCSharp
{
    #region Delegate
    public delegate void MulticastDelegate(out int number);
    #endregion
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public Employee(int id, string name, string email, Gender gender)
        {
            Id = id;
            Name = name;
            Email = email;
            Gender = gender;
        }
        public Employee()
        {
            Id = 0;
            Name = string.Empty;
            Email = string.Empty;
           
        }

     
    }
}
