using LoanSystem.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LoanSystem.Api
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(Loans)))
                host.Open();
            Console.WriteLine("Host started @ : " + DateTime.Now);
            Console.ReadLine();
        }
    }
}
