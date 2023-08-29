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
            List<Loan> loanList = new List<Loan>();
            UserInterface.StartMenu();

            for(int i = 0; i < 5; i++)
            {
                loanList.Add(UserInterface.MainMenu());
            }

            foreach (Loan loan in loanList)
            {
                Console.WriteLine(loan.ToString());
            }
            
            Console.Read();
        }
    }
}
