using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PRG281_Nel_Pieter_Proj_Console;

namespace PRG281_Nel_Pieter_Proj
{
    internal class Program
    {
       
        public static void Main(string[] args)
        {
            int maxNumberOfLoans = 2;
            List<Loan> loanList = new List<Loan>();
            UserInterface.StartMenu();


            for(int i = 0; i < maxNumberOfLoans; i++)
            {
                UserInterface.MainMenu();
                loanList.Add(UserInterface.ReturnLoan());
            }

            Console.WriteLine("Loans Created: ");

            foreach (Loan loan in loanList)
            {
                loan.DisplayDetails();
            }

            Console.Read();
        }
    }
}
