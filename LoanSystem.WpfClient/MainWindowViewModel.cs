using System;
using System.Threading.Tasks;
using LoanSystem.WpfClient.LoanService;

namespace LoanSystem.WpfClient
{
    public class MainWindowViewModel
    {
        private readonly LoansClient loanService;

        public MainWindowViewModel()
        {
            loanService = new LoansClient();
        }

        public string Result => "Hello";

        public async Task<int> CreateLoan()
        {
            var newLoan = new Loan()
            {
                Id = 999,
                Title = "This is a new loan",
                Amount = 100000M,
                Maturity = DateTime.Now
            };

 
            var id = await loanService.CreateLoanAsync(newLoan);
            return id;
 
        }
    }
}
