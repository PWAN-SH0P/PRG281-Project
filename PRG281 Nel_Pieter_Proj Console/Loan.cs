using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRG281_Nel_Pieter_Proj
{
    internal class Loan : LoanConstants
    {
        protected int _loanNumber;
        protected string _customerLastName;
        protected string _customerFirstName;
        protected double _loanAmount;
        protected LoanTerm _loanTerm;
        protected const LoanTerm _defaultTerm = LoanTerm.Short;
        public static double PrimeInterestRate {get; set;}
        protected double _maxLoanAmount = 100000.0;


        public Loan(int loanNumber, string customerName, string customerSurname, double loanAmount, LoanTerm loanTerm) 
        {
            _loanNumber = loanNumber;
            _customerFirstName = customerName;
            _customerLastName = customerSurname;
            _loanAmount = loanAmount;
            _loanTerm = loanTerm;
            SetPrimeInterestRate();
        }

        public void SetPrimeInterestRate()
        {
            Console.WriteLine("Enter the prime interest rate");
            string enteredInterestRate = Console.ReadLine();

            if(double.TryParse(enteredInterestRate, out double interestRate))
            {
                PrimeInterestRate = interestRate;
            }
        }

        public override string ToString()
        {
            return "{" + $"Loan number: {_loanNumber}, First Name: {_customerFirstName} " +
                   $"Last Name: {_customerLastName}, Loan Amount: {_loanAmount}";

        }
    }
}
