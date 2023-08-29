using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace PRG281_Nel_Pieter_Proj
{
    internal class Loan : LoanConstants
    {
        public delegate void LoanCreationHandler(int loanNumber, string customerName, string customerSurname, double loanAmount, LoanTerm loanTerm);
        public static event LoanCreationHandler LoanCreated;

        protected int _loanNumber;
        protected string _customerLastName;
        protected string _customerFirstName;
        protected double _loanAmount;
        protected LoanTerm _loanTerm;
        protected const LoanTerm _defaultTerm = LoanTerm.Short;
        protected double _maxLoanAmount = 100000.0;


        public void CreateLoan(int loanNumber, string customerName, string customerSurname, double loanAmount, LoanTerm loanTerm)
        {
            LoanCreated?.Invoke(loanNumber, customerName, customerSurname, loanAmount, loanTerm);
        }

        public Loan(int loanNumber, string customerName, string customerSurname, double loanAmount, LoanTerm loanTerm) 
        {
            _loanNumber = loanNumber;
            _customerFirstName = customerName;
            _customerLastName = customerSurname;
            _loanAmount = loanAmount;
            _loanTerm = loanTerm;
            SetPrimeInterestRate();
        }

        public static void SetPrimeInterestRate()
        {

            double interestRate;

            Console.WriteLine("Please enter the prime interest rate (%)");
            string enteredInterestRate = Console.ReadLine();

            if(double.TryParse(enteredInterestRate, out interestRate))
            {
                PrimeInterestRate = interestRate/100.0;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Enter a valid prime interest rate");
                SetPrimeInterestRate();
            }

        }

        public override string ToString()
        {
            return "{" + $"Loan number: {_loanNumber}, First Name: {_customerFirstName} " +
                   $"Last Name: {_customerLastName}, Loan Amount: {_loanAmount}" + "}";

        }
    }
}
