using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace LoanSystem.Api
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Loans : ILoans
    {
        public int CreateLoan(Loan loan)
        {

            Debug.WriteLine($"Start creating of Loan ......");
            throw new InvalidOperationException("Something went wrong on server");

            //artificial delay
            Thread.Sleep(5000);

            Debug.WriteLine($"Completed creation new Loan Id: {loan.Id}");


            //return loan.Id;
        }

        public string GetLoans()
        {
            Debug.WriteLine("loan list requested");
            return string.Format("You have xx loans");
        }

        
    }
}
