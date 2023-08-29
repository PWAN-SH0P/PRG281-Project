using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG281_Nel_Pieter_Proj
{
    internal class PersonalLoan : Loan
    {

        PersonalLoan(int loanNumber, string customerName, string customerSurname, double loanAmount, LoanTerm loanTerm): base(loanNumber, customerName, customerSurname, loanAmount, loanTerm)
        {
            PrimeInterestRate += 0.02;
        }

        public static PersonalLoan CreateLoan(int loanNumber, string customerName, string customerSurname, double loanAmount, LoanTerm loanTerm)
        {
            PersonalLoan personalLoan = new PersonalLoan(loanNumber, customerName,customerName, loanAmount, loanTerm);
            return personalLoan;
        }
    }
}
