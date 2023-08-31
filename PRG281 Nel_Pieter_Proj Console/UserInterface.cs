using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PRG281_Nel_Pieter_Proj;

namespace PRG281_Nel_Pieter_Proj_Console
{
    internal class UserInterface
    {
        private static LoanData loanData = new LoanData();      // to confirm if a loan should be added or if its data be changed
        private static Loan loan;



        public static void StartMenu()      // Opens a welcome screen and prompts for the prime interest rate
        {
            Console.WriteLine($"Welcome to {Loan.CompanyName}!");
            Loan.SetPrimeInterestRate();
        }

        public static void MainMenu()       // This screen appears for the addition of every loan
        {
            ChooseLoanType();                                   // The type of loan is chosen
            EnterLoanDetails();                                 // Then the user is prompted for details
            bool confirmEntry = ConfirmEntry(loanData);         // Finally, the user is asked if the details are correct

            if (!confirmEntry)        // Restarts menu if the user wishes to change the details for the most recent loan
            {                               // Does not affect previous loans
                Console.Clear();
                Console.WriteLine("Editing loan");
                MainMenu();
                return;
            }

            switch(loanData.TypeOfLoan)     // Creates loan based on the chosen type
            {
                case LoanType.Business:
                    Console.Clear();
                    loan = PersonalLoan.CreateLoan(loanData);
                    break;

                default:
                    Console.Clear();
                    loan = BusinessLoan.CreateLoan(loanData);
                    break;
            }
        }

        public static void ChooseLoanType()     // Prompts user to choose the type of loan
        {
            int loanTypeInt;
            Console.WriteLine("Choose Loan Type");
            Console.WriteLine("0. Personal Loan");
            Console.WriteLine("1. Business Loan");

            string loanTypeRaw = Console.ReadLine();

            if(!int.TryParse(loanTypeRaw, out loanTypeInt) || loanTypeInt > 1 || loanTypeInt < 0) // Checks if input can be parsed as int
            {                                                                                     // If so, checks if in valid range
                Console.Clear();                                                                  // If invalid, prompts for loan type again
                Console.WriteLine("Invalid loan type");
                ChooseLoanType();
                return;
            }

            loanData.TypeOfLoan = (LoanType)loanTypeInt;        // Converts selection to item in enum LoanType
           
        }
   
        public static void EnterLoanDetails()   // Prompts user for loan details
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
            int loanTermInt = -1;    // Set to -1 as a hack. Later code needs this and TryParse might not produce a value


            if (!int.TryParse(loanNumberRaw, out int loanNumber))  // Checks if the loan number entered can be parsed as int
            {                                                      // outputs loanNumber as double, if it can
                Console.Clear();                                   // Restarts prompt for this loan, if not
                Console.WriteLine("Invalid loan number");
                EnterLoanDetails();
                return;
            }

            if (!double.TryParse(loanAmountRaw, out double loanAmount)) // As with loanNumber
            {                                                           
                Console.Clear();
                Console.WriteLine("Invalid loan amount");
                EnterLoanDetails();
                return;
            }

            if(loanTermRaw == "")       // Loan term must default to Short, according to instructions
            {
                loanData.TermOfLoan = LoanTerm.Short;
            }
            else if(!int.TryParse(loanTermRaw, out loanTermInt) || loanTermInt > 2  || loanTermInt < 0) // As with loanNumber, but checks if in valid range for enum LoanTerm
            {
                Console.Clear();
                Console.WriteLine("Invalid loan term");
                EnterLoanDetails();
                return;
            }

            if (loanData.TermOfLoan != LoanTerm.Short)  // TermOfLoan will be null, unless set to default value due to empty input
            { 
                loanData.TermOfLoan = (LoanTerm)loanTermInt; 
            } 
                
            loanData.LoanNumber = loanNumber;
            loanData.CustomerName = customerName;
            loanData.CustomerSurname = customerSurname;
            loanData.LoanAmount = loanAmount;
        }

        public static bool ConfirmEntry(LoanData loanData)  // Asks if user wants to add the current loan, or re-enter details
        {
            Console.WriteLine("The data for this loan is: ");
            Console.WriteLine(loanData.ToString());
            Console.WriteLine("Edit? (y/n)");

            string editSelected = Console.ReadLine().ToUpper();

            if(editSelected == "Y")
            {
                return false;
            }

            if(editSelected == "N")
            {
                return true;
            }
            Console.Clear();
            Console.WriteLine("Enter Y or N");
            return ConfirmEntry(loanData);

        }

        public static Loan ReturnLoan() // Returns the loan created. This probably isn't the right way to go about this.
        {
            return loan;
        }
    }
}

