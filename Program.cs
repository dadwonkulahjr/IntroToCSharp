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
        public static int CustomEmployeeSort(Employee x, Employee y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
        static void Main()
        {
            try
            {
                List<Employee> listOfEmployeesFullTimeEmployee = Employee.FullTimeEmployee();
                List<Employee> listOfEmployeesPartTimeEmployee = Employee.PartTimeEmployee();
                Console.WriteLine("Before Sorting Part time Employee:");
                foreach (Employee e in listOfEmployeesPartTimeEmployee)
                {
                    Console.WriteLine($"ID = {e.Id.ToString()} Name = {e.Name} Gender = {e.Gender}" +
                        $" Salary = {e.Salary.ToString("c")} Type Of Employee = {e.Type}");
                }
                Console.WriteLine();
                Console.WriteLine("Now after Sorting By Name in Ascending:");
                SortEmployeeByName sortEmployeeByName = new SortEmployeeByName();
                listOfEmployeesPartTimeEmployee.Sort(sortEmployeeByName);
                foreach (Employee e in listOfEmployeesPartTimeEmployee)
                {
                    Console.WriteLine($"ID = {e.Id.ToString()} Name = {e.Name} Gender = {e.Gender}" +
                        $" Salary = {e.Salary.ToString("c")} Type Of Employee = {e.Type}");
                }
                Console.WriteLine();
                Console.WriteLine("Sorting Name in Descending Order:");
                listOfEmployeesPartTimeEmployee.Reverse();
                foreach (Employee e in listOfEmployeesPartTimeEmployee)
                {
                    Console.WriteLine($"ID = {e.Id.ToString()} Name = {e.Name} Gender = {e.Gender}" +
                        $" Salary = {e.Salary.ToString("c")} Type Of Employee = {e.Type}");
                }
                Console.WriteLine();
                SortEmployeeBySalary sortEmployeeBySalary = new SortEmployeeBySalary();
                Console.WriteLine("Before Sorting Salaries:");
                foreach (Employee e in listOfEmployeesPartTimeEmployee)
                {
                    Console.WriteLine(e.Salary.ToString("c"));
                }
                listOfEmployeesPartTimeEmployee.Sort(sortEmployeeBySalary);
                Console.WriteLine("After Sorting by Salaries in Ascending Order:");
                foreach (Employee e in listOfEmployeesPartTimeEmployee)
                {
                    Console.WriteLine(e.Salary.ToString("c"));
                }
                Console.WriteLine();
                listOfEmployeesPartTimeEmployee.Reverse();
                Console.WriteLine("After Sorting Salaries in Descending Order:");
                foreach (Employee e in listOfEmployeesPartTimeEmployee)
                {
                    Console.WriteLine(e.Salary.ToString("c"));
                }
                Console.WriteLine();
                Console.WriteLine("Before Sorting Employee By Email:");
                SortEmployeeByEmail sortEmployeeByEmail = new SortEmployeeByEmail();
                foreach (Employee e in listOfEmployeesPartTimeEmployee)
                {
                    Console.WriteLine(e.Email);
                }

                Console.WriteLine();
                Console.WriteLine("After Sorting Employee By Email in Ascending Order:");
                listOfEmployeesPartTimeEmployee.Sort(sortEmployeeByEmail);
                foreach (Employee e in listOfEmployeesPartTimeEmployee)
                {
                    Console.WriteLine(e.Email);
                }
                Console.WriteLine();
                Console.WriteLine("After Sorting Employee By Email Descending Order:");
                listOfEmployeesPartTimeEmployee.Reverse();
                foreach (Employee e in listOfEmployeesPartTimeEmployee)
                {
                    Console.WriteLine(e.Email);
                }
                Console.WriteLine();
                Console.WriteLine("Before Sorting by Gender:");
                foreach (Employee e in listOfEmployeesPartTimeEmployee)
                {
                    Console.WriteLine(e.Gender);
                }
                SortEmployeeByGender sortEmployeeByGender = new SortEmployeeByGender();
                Console.WriteLine();
                Console.WriteLine("After Sorting by Gender in Ascending Order:");
                listOfEmployeesPartTimeEmployee.Sort(sortEmployeeByGender);
                foreach (Employee e in listOfEmployeesPartTimeEmployee)
                {
                    Console.WriteLine(e.Gender);
                }
                Console.WriteLine();
                Console.WriteLine("After Sorting by Gender in Descending Order:");
                listOfEmployeesPartTimeEmployee.Reverse();
                foreach (Employee e in listOfEmployeesPartTimeEmployee)
                {
                    Console.WriteLine(e.Gender);
                }
                Console.WriteLine();

                Console.WriteLine("Sorting By Name using Delegate:");
                listOfEmployeesPartTimeEmployee.Sort((x, y) => { return x.Name.CompareTo(y.Name); });
              
                foreach (Employee e in listOfEmployeesPartTimeEmployee)
                {
                    Console.WriteLine(e.Name);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }



    }



}




