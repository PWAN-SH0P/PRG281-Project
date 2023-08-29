using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG281_Nel_Pieter_Proj;

namespace PRG281_Nel_Pieter_Proj_Console
{
    internal class UserInterface
    {
        private static LoanType loanType;


        public void StartMenu()
        {
            Console.WriteLine($"Welcome to {Loan.CompanyName}!");
            Loan.SetPrimeInterestRate();
        }

        public void ChooseLoanType()
        {
            Console.WriteLine("Choose Loan Type");
            Console.WriteLine("0. Personal Loan");
            Console.WriteLine("1. Business Loan");

            int loanTypeInt;
            string loanTypeRaw = Console.ReadLine();

            if(!int.TryParse(loanTypeRaw, out loanTypeInt) || loanTypeInt > 1)
            {
                Console.Clear();
                ChooseLoanType();
                return;
            }

            loanType = (LoanType)loanTypeInt;
        }
   
        public void SetLoanDetails(Loan loan)
        {

            Console.WriteLine("Enter Loan Number: ");
            string loanNumberRaw = Console.ReadLine();

            Console.WriteLine("Enter Customer Name: ");
            string customerName = Console.ReadLine();

            Console.WriteLine("Enter Customer Surname: ");
            string customerSurname = Console.ReadLine();

            Console.WriteLine("Enter Loan Amount: ");
            string loanAmountRaw = Console.ReadLine();

            Console.WriteLine("Select Loan Term: ");
            Console.WriteLine("0. Short (1 year)");
            Console.WriteLine("1. Medium (3 years)");
            Console.WriteLine("2. Long (5 years)");
            string loanTermRaw = Console.ReadLine();


            if(!int.TryParse(loanNumberRaw, out int loanNumber))
            {
                Console.Clear();
                Console.WriteLine("Invalid loan number");
                SetLoanDetails(loan);
            }

            if (!double.TryParse(loanAmountRaw, out double loanAmount))
            {
                Console.Clear();
                Console.WriteLine("Invalid loan amount");
                SetLoanDetails(loan);
            }

            if(!int.TryParse(loanTermRaw, out int loanTermInt) || loanTermInt > 2)
            {
                Console.Clear();
                Console.WriteLine("Invalid loan term");
                SetLoanDetails(loan);
            }

        }

    }
}

