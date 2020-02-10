using System;
using System.Collections.Generic;
using System.Text;

namespace Test1.Models
{
   public class Contract : Employee
    {
        private int _contractLength { get; set; }
        private static double _contractTaxPercentage { get; set; }
        private static int _numberOfMonthsForTax { get; set; }
        private static double _defaultReturnAmount { get; set; }

        public Contract(string employeeName, string employeePosition, double employeeSalary, int contractLength) : base(employeeName, employeePosition, employeeSalary)
        {
            _contractLength = contractLength;
            _contractTaxPercentage = 0.1;
            _numberOfMonthsForTax = 6;
            _defaultReturnAmount = 0;
        }

        public Contract(string employeeName, string employeePosition, double employeeSalary,double defaultReturnAmount, int contractLength, double contractTaxPecentage, int numberOfMonthsForTax) : base(employeeName, employeePosition, employeeSalary)
        {
            _contractLength = contractLength;
            _contractTaxPercentage = contractTaxPecentage;
            _numberOfMonthsForTax = numberOfMonthsForTax;
            _defaultReturnAmount = defaultReturnAmount;
        }

        public override double CalculateEmployeeTax()
        {   
            return (_contractLength > _numberOfMonthsForTax) ? base.CalculateEmployeeTax() * _contractTaxPercentage : _defaultReturnAmount;
        }
    }
}
