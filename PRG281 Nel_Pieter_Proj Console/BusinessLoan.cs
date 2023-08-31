using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG281_Nel_Pieter_Proj
{
    internal class BusinessLoan : Loan
    {
        BusinessLoan(LoanData loanData) : base(loanData)
        {
            InterestRate = PrimeInterestRate + 0.01;
        }

        public static BusinessLoan CreateLoan(LoanData loanData)
        {
            BusinessLoan businessLoan = new BusinessLoan(loanData);
            return businessLoan;
        }

        public override string ToString()
        {
            return base.ToString() + $" \t Loan Type: Business";
        }
    }
}
