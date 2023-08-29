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


    }
}
