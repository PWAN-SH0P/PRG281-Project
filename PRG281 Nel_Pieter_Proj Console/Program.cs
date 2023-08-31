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
            bool runMenu = true;
            while (runMenu)
            {
                UserInterface.CreationMenu();
                Console.WriteLine("Would you like to start again? (Y/N)");

                while (true)
                {
                    string editSelected = Console.ReadLine().ToUpper();

                    if (editSelected == "Y")
                    {
                        runMenu = true;
                        break;
                    }

                    if (editSelected == "N")
                    {
                        runMenu = false;
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("Enter Y or N");
                }                
            }
            Console.WriteLine($"Thank you for using {LoanConstants.CompanyName}!" );

        }
    }
}
