using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

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
        protected double _repaymentAmount;
        public static double PrimeInterestRate { get; set; }
        public static double InterestRate { get; set; }

        Dictionary<LoanTerm, int> yearsOfTerm = new Dictionary<LoanTerm, int>();


        public Loan(LoanData loanData) 
        {
            _loanNumber = loanData.LoanNumber;
            _customerFirstName = loanData.CustomerName; 
            _customerLastName = loanData.CustomerSurname; 
            _loanAmount = loanData.LoanAmount; 
            _loanTerm = loanData.TermOfLoan;

            yearsOfTerm.Add(LoanTerm.Short, 1);
            yearsOfTerm.Add(LoanTerm.Medium, 3);
            yearsOfTerm.Add(LoanTerm.Long, 5);

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

        private string SetRepaymentAmount()
        {
            string repaymentAmount = (_loanAmount * (Math.Pow((1 + InterestRate), yearsOfTerm[_loanTerm]))).ToString("C", new CultureInfo("en-ZA"));
            return repaymentAmount;
        }


        public override string ToString()
        {
            string loanAmountString = _loanAmount.ToString("C", new CultureInfo("en-ZA"));

            return $"Loan number: {_loanNumber} \t First Name: {_customerFirstName} \t" +
                   $"Last Name: {_customerLastName} \t Loan Amount: {loanAmountString} \t Loan Term: {_loanTerm} ({yearsOfTerm[_loanTerm]}) \t Repayment Amount: {SetRepaymentAmount()}";

        }

        public void DisplayDetails()
        {
            Console.WriteLine(this.ToString());
        }
    }
}