using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using PRG281_Nel_Pieter_Proj;

namespace PRG281_Nel_Pieter_Proj_Console
{
    internal class UserInterface
    {
        private static LoanType loanType;
        private static string customerName = Console.ReadLine();
        private static string customerSurname = Console.ReadLine();
        private static int loanNumber;
        private static double loanAmount;
        
        
        public void StartMenu()
        {
            Console.WriteLine($"Welcome to {Loan.CompanyName}!");
            Loan.SetPrimeInterestRate();
            ChooseLoanType();
            EnterLoanDetails();

            switch(loanType)
            {
                case LoanType.Business:
                    Loan.LoanCreated += PersonalLoan.CreateLoan;
                    break;
                case LoanType.Personal:
                    Loan.LoanCreated += BusinessLoan.CreateLoan;
            }

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
   
        public void EnterLoanDetails()
        {

            Console.WriteLine("Enter Loan Number: ");
            string loanNumberRaw = Console.ReadLine();

            Console.WriteLine("Enter Customer Name: ");
            string enteredCustomerName = Console.ReadLine();

            Console.WriteLine("Enter Customer Surname: ");
            string enteredCustomerSurname = Console.ReadLine();

            Console.WriteLine("Enter Loan Amount: ");
            string loanAmountRaw = Console.ReadLine();

            Console.WriteLine("Select Loan Term: ");
            Console.WriteLine("0. Short (1 year)");
            Console.WriteLine("1. Medium (3 years)");
            Console.WriteLine("2. Long (5 years)");
            string loanTermRaw = Console.ReadLine();


            if(!int.TryParse(loanNumberRaw, out int enteredLoanNumber))
            {
                Console.Clear();
                Console.WriteLine("Invalid loan number");
                EnterLoanDetails();
                return;
            }

            if (!double.TryParse(loanAmountRaw, out double enteredLoanAmount))
            {
                Console.Clear();
                Console.WriteLine("Invalid loan amount");
                EnterLoanDetails();
                return;
            }

            if(!int.TryParse(loanTermRaw, out int loanTermInt) || loanTermInt > 2)
            {
                Console.Clear();
                Console.WriteLine("Invalid loan term");
                EnterLoanDetails();
                return;
            }

            loanNumber = enteredLoanNumber;
            customerName = enteredCustomerName;
            customerSurname = enteredCustomerSurname;
            loanAmount = enteredLoanAmount;
        }
    }
}

