using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG281_Nel_Pieter_Proj
{
    internal class BusinessLoan : Loan
    {
        BusinessLoan(LoanDataHandler loanDataHandler) : base(loanDataHandler)
        {
            PrimeInterestRate += 0.01;
        }

        public static BusinessLoan CreateLoan(LoanDataHandler loanDataHandler)
        {
            BusinessLoan businessLoan = new BusinessLoan(loanDataHandler);
            return businessLoan;
        }
    }
}
