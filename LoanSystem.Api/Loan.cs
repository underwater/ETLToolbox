using System;

namespace LoanSystem.Api
{

    public class Loan
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Amount { get; set; }
        public DateTime Maturity { get; set; }
    }
}