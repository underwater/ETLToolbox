using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LoanSystem.Core
{
    [ServiceContract]
    public interface ILoans
    {
        [OperationContract]
        void CreateLoan(string loan);
    }
}
