using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LoanSystem.Api
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Loans : ILoans
    {
        public Guid CreateLoan(string loanName)
        {
            var guid = Guid.NewGuid();
            Debug.WriteLine($"New Loan Created : {guid}");
            return guid;
        }

        public string GetLoans()
        {
            Debug.WriteLine("loan list requested");
            return string.Format("You have xx loans");
        }

        
    }
}
