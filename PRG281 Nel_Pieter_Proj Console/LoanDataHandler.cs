using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG281_Nel_Pieter_Proj
{
    class LoanDataHandler
    {
        public int LoanNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname {get; set; }
        public double LoanAmount { get; set; }
        public LoanTerm TermOfLoan { get; set; }
        public LoanType TypeOfLoan { get; set; }
    }
}
