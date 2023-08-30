using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG281_Nel_Pieter_Proj
{
    internal class PersonalLoan : Loan
    {

        PersonalLoan(LoanDataHandler loanDataHandler): base(loanDataHandler)
        {
            PrimeInterestRate += 0.02;
        }

        public static PersonalLoan CreateLoan(LoanDataHandler loanDataHandler)
        {
            PersonalLoan personalLoan = new PersonalLoan(loanDataHandler);
            return personalLoan;
        }

        public override string ToString()
        {
            return base.ToString() + $" \t Loan Type: Personal";
        }
    }
}
