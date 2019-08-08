using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanSystem.Core
{
    public class Loans : ILoans
    {
        public void CreateLoan(string loan)
        {
            Console.WriteLine($"added a new loan {loan}");
        }
    }
}
