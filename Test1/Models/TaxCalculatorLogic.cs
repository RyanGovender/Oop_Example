using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test1.Models
{
    public class TaxCalculatorLogic
    {
        private static List<Tax> _taxBracket = GetTaxBrackets();
        private static double _defaultReturnAmount = 0;

        public static List<Tax> GetTaxBrackets()
        {
            _taxBracket = new List<Tax>
            {
                new Tax(10000, 5000, 0.1),
                new Tax(15000, 10000, 0.15),
                new Tax(20000, 15000, 0.2),
                new Tax(30000, 20000, 0.25),
                new Tax(double.MaxValue, 30000, 0.3)
            };

            return _taxBracket;
        }

        public static double CalculateTax(double employeeSalary)
        {
            foreach (var tax in _taxBracket)
            {
                if (employeeSalary >= tax.Lower && employeeSalary <= tax.Upper)
                {
                    return employeeSalary * tax.TaxPercentage;
                }
            }
            return _defaultReturnAmount;
        }
    }
}
    