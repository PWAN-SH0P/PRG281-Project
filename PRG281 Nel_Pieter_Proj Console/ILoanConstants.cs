using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG281_Nel_Pieter_Proj
{
    public class LoanConstants
    {
        private const string _companyName = "Unique Building Services Loan Company";
        private const double _maxLoanAmount = 100000.0;
        private const double _primeInterestRate = 0.1;

        public static string CompanyName
        {
            get { return _companyName; }
        }

        public static double MaxLoanAmount
        {
            get { return _maxLoanAmount; }
        }

        public static double PrimeInterestRate
        {
            get { return (_primeInterestRate); } 
        }
    }
}


