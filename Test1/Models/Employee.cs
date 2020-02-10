using System;
using System.Collections.Generic;
using System.Text;

namespace Test1.Models
{
    public class Employee
    {
        public string EmployeeName { get; }
        public string EmployeePosition { get; }
        public double EmployeeSalary { get; }

        public Employee()
        {

        }

        public Employee(string employeeName, string employeePosition, double employeeSalary)
        {
            EmployeeName = employeeName;
            EmployeePosition = employeePosition;
            EmployeeSalary = employeeSalary;
        }

        public virtual double CalculateEmployeeTax()
        {
           return TaxCalculatorLogic.CalculateTax(EmployeeSalary);
        }

        public void Display()
        {
            Console.WriteLine($"\n Employee Name : {EmployeeName}" +
                              $"\n Employee Position : {EmployeePosition}" +
                              $"\n Employee Net Salary : R{EmployeeSalary}" +
                              $"\n Employee Tax: R{CalculateEmployeeTax()}" +
                              $"\n Employee Gross Salary : {EmployeeSalary - CalculateEmployeeTax()}");
        }
    }
}
