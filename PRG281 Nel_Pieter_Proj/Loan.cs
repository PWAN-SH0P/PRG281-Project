using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG281_Nel_Pieter_Proj
{
    internal class Loan 
    {
        protected int _loanNumber;
        protected string _customerLastName;
        protected string _customerFirstName;
        protected double _loanAmount;
        protected LoanTerm _loanTerm;
        protected const LoanTerm _defaultTerm = LoanTerm.Short;
        protected double _interestRate = 0.05;
        protected double _maxLoanAmount = 100000.0;


        public Loan(int loanNumber, string customerName, string customerSurname, double loanAmount, LoanTerm loanTerm) 
        {
            _loanNumber = loanNumber;
            _customerFirstName = customerName;
            _customerLastName = customerSurname;
            _loanAmount = loanAmount;
            _loanTerm = loanTerm;
        }

        public override string ToString()
        {
            return "{" + $"Loan number: {_loanNumber}, First Name: {_customerFirstName} " +
                   $"Last Name: {_customerLastName}, Loan Amount: {_loanAmount}";

        }
    }
}
