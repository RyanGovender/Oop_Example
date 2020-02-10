using System;
using System.Collections.Generic;
using System.Text;

namespace Test1.Models
{
    public class Tax
    {
        public double Upper { get; set; }
        public double Lower { get; set; }
        public double TaxPercentage { get; set; }

        public Tax()
        {

        }

        public Tax(double upper, double lower, double taxPercentage)
        {
            Upper = upper;
            Lower = lower;
            TaxPercentage = taxPercentage;
        }
    }
}
