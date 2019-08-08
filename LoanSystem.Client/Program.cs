using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanSystem.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new LoanService.LoansClient();

            // get list of loans
            var res = client.GetLoans();
            Console.WriteLine(res);


            // create new loan
            var newloan = client.CreateLoan("New Loan");
            Console.WriteLine(newloan);
            Console.ReadLine();
        }
    }
}
