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
        private const int _maxNumberOfLoans = 2;

        public static string CompanyName
        {
            get { return _companyName; }
        }

        public static double MaxLoanAmount
        {
            get{ return _maxLoanAmount;}
        }

        public static int MaxNumberOfLoans { get { return _maxNumberOfLoans; } }
    }
}


