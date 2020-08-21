using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToCSharp
{
    #region Delegate
    public delegate void MulticastDelegate(out int number);
    #endregion
    public class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public Gender Gender { get; set; }
        public string Type { get; set; }
        public Employee(int id, string name, string email, decimal salary, Gender gender, string type)
        {
            Id = id;
            Name = name;
            Email = email;
            Salary = salary;
            Gender = gender;
            Type = type;
        }

        public static List<Employee> FullTimeEmployee()
        {
            return new List<Employee>()
                 {
                     new Employee(1, "Mike", "mike@gmail.com", 5000,gender:Gender.Male, type:"-FullTimeEmployee"),
                     new Employee(2, "Precious", "precious@yahoo.com", 4500,gender:Gender.Female,type:"-FullTimeEmployee"),
                     new Employee(3, "James", "james@hotmail.com", 7000,gender:Gender.Male,type:"-FullTimeEmployee")
                     //new Employee(4, "Princess", "princess@yahoo.com", 2500,gender:Gender.Female,type:"-FullTimeEmployee"),
                     //new Employee(5, "Mary", "mart@outlook.com", 3500,gender:Gender.Female,type:"-FullTimeEmployee"),
                     //new Employee(6, "Aliia", "alicia@gmail.com", 3400,gender:Gender.Female,type:"-FullTimeEmployee")
                };
        }
        public static List<Employee> PartTimeEmployee()
        {
            return new List<Employee>()
            {
                new Employee(1, "Mary", "mary@outlook.com", 3500,gender:Gender.Female,type:"-PartTimeEmployee"),
                new Employee(2, "Alicia", "alicia@gmail.com", 3400,gender:Gender.Female,type:"-PartTimeEmployee"),
                new Employee(3, "Princess", "princess@yahoo.com", 2500,gender:Gender.Female,type:"-PartTimeEmployee"),
                new Employee(4, "Ben", "ben@yahoo.com", 1500,gender:Gender.Male,type:"-PartTimeEmployee")
            };
        }

        public int CompareTo(Employee other)
        {
            return Name.CompareTo(other.Name);
        }
    }
   

}
