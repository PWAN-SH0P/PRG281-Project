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

        private static LoanDataHandler loanData = new LoanDataHandler();


        public static void StartMenu()
        {
            Console.WriteLine($"Welcome to {Loan.CompanyName}!");
            Loan.SetPrimeInterestRate();
        }

        public static Loan MainMenu()
        {
            ChooseLoanType();
            EnterLoanDetails();

            switch(loanData.TypeOfLoan)
            {
                case LoanType.Business:
                    Console.Clear();
                    return PersonalLoan.CreateLoan(loanData);

                default:
                    Console.Clear();
                    return BusinessLoan.CreateLoan(loanData);
            }
        }

        public static void ChooseLoanType()
        {
            int loanTypeInt;
            Console.WriteLine("Choose Loan Type");
            Console.WriteLine("0. Personal Loan");
            Console.WriteLine("1. Business Loan");

            string loanTypeRaw = Console.ReadLine();

            if(!int.TryParse(loanTypeRaw, out loanTypeInt) || loanTypeInt > 1 || loanTypeInt < 0)
            {
                Console.Clear();
                ChooseLoanType();
                return;
            }

            loanData.TypeOfLoan = (LoanType)loanTypeInt;
           
        }
   
        public static void EnterLoanDetails()
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
            int loanTermInt = -1;


            if (!int.TryParse(loanNumberRaw, out int loanNumber))
            {
                Console.Clear();
                Console.WriteLine("Invalid loan number");
                EnterLoanDetails();
                return;
            }

            if (!double.TryParse(loanAmountRaw, out double loanAmount))
            {
                Console.Clear();
                Console.WriteLine("Invalid loan amount");
                EnterLoanDetails();
                return;
            }

            if(loanTermRaw == "")
            {
                loanData.TermOfLoan = LoanTerm.Short;
            }
            else if(!int.TryParse(loanTermRaw, out loanTermInt) || loanTermInt > 2  || loanTermInt < 0)
            {
                Console.Clear();
                Console.WriteLine("Invalid loan term");
                EnterLoanDetails();
                return;
            }

            if (loanData.TermOfLoan != LoanTerm.Short) { loanData.TermOfLoan = (LoanTerm)loanTermInt; }
                
            loanData.LoanNumber = loanNumber;
            loanData.CustomerName = customerName;
            loanData.CustomerSurname = customerSurname;
            loanData.LoanAmount = loanAmount;
        }
    }
}

