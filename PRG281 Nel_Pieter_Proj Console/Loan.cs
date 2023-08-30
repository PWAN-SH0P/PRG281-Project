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

        protected int _loanNumber;
        protected string _customerLastName;
        protected string _customerFirstName;
        protected double _loanAmount;
        protected LoanTerm _loanTerm;
        protected const LoanTerm _defaultTerm = LoanTerm.Short;
        protected double _maxLoanAmount = 100000.0;


        public Loan(LoanData loanData) 
        {
            _loanNumber = loanData.LoanNumber;
            _customerFirstName = loanData.CustomerName; 
            _customerLastName = loanData.CustomerSurname; 
            _loanAmount = loanData.LoanAmount; 
            _loanTerm = loanData.TermOfLoan;
        }

        public static void SetPrimeInterestRate()
        {

            Console.WriteLine("Please enter the prime interest rate (%)");
            string enteredInterestRate = Console.ReadLine();

            if(!double.TryParse(enteredInterestRate, out double interestRate))
            {
                Console.Clear();
                Console.WriteLine("Enter a valid prime interest rate");
                return;
            }
            else
            {
                PrimeInterestRate = interestRate / 100.0;
                return;
            }

        }

        /*
        private static void SetRepaymentAmount()
        {

        }
        */


        public override string ToString()
        {
            return  $"Loan number: {_loanNumber} \t First Name: {_customerFirstName} \t" +
                   $"Last Name: {_customerLastName} \t Loan Amount: {_loanAmount} \t Loan Term: {_loanTerm}";

        }

        public void DisplayDetails()
        {
            Console.WriteLine(this.ToString());
        }
    }
}