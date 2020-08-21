using CustomLibery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace IntroToCSharp
{
    class Program
    {
        public static void Display(Employee employee)
        {
            Console.WriteLine($"Id = {employee.Id} && Name = {employee.Name} && Email = {employee.Email} && Salary = {employee.Salary.ToString("c")} && Gender = {employee.Gender} ");
        }
        static void Main()
        {
            try
            {
              
                List<Employee> fullTimeEmployee = Employee.FullTimeEmployee();
                List<Employee> partTimeEmployee = Employee.PartTimeEmployee();

                Console.WriteLine("List Of Full Time Employee");
                foreach (Employee fullTimeEmp in fullTimeEmployee)
                {
                    Console.WriteLine($"Id = {fullTimeEmp.Id} Name = {fullTimeEmp.Name} Gender = {fullTimeEmp.Gender} " +
                        $"Email = {fullTimeEmp.Email} Salary = {fullTimeEmp.Salary.ToString("c")} TypeOfEmployee = {fullTimeEmp.Type}");
                }
                Console.WriteLine();
                Console.WriteLine("Part Time Employee");
                foreach (Employee partTimeEmp in partTimeEmployee)
                {
                    Console.WriteLine($"Id = {partTimeEmp.Id} Name = {partTimeEmp.Name} Gender = {partTimeEmp.Gender}" +
                      $" Email = {partTimeEmp.Email} Salary = {partTimeEmp.Salary.ToString("c")} TypeOfEmployee = {partTimeEmp.Type}");
                }
                Console.WriteLine();
                Console.WriteLine("Add Some fulltime employee to the List of Part time Employee Before Sorting:");
                partTimeEmployee.AddRange(fullTimeEmployee);
                foreach (Employee employee in partTimeEmployee)
                {
                    Console.WriteLine($"Id = {employee.Id} Name = {employee.Name} Gender = {employee.Gender}" +
                                         $" Email = {employee.Email} Salary = {employee.Salary.ToString("c")} TypeOfEmployee = {employee.Type}");
                }
                Console.WriteLine();
                Console.WriteLine("After Sorting:");
                partTimeEmployee.Sort();
                foreach (Employee employee in partTimeEmployee)
                {
                    Console.WriteLine($"Id = {employee.Id} Name = {employee.Name} Gender = {employee.Gender}" +
                                         $" Email = {employee.Email} Salary = {employee.Salary.ToString("c")} TypeOfEmployee = {employee.Type}");
                }
                Console.WriteLine();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }



    }



}




