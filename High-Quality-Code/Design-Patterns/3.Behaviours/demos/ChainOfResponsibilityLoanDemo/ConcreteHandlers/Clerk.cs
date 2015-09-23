namespace ChainOfResponsibilityLoanDemo
{
    using System;

    internal class Clerk : LoanHandler
    {
        private const decimal ApproveLimit = 10000M;

        public override void ApproveRequest(Loan loanRequest)
        {
            if (loanRequest.Amount < ApproveLimit)
            {
                Console.WriteLine("Approved {0:C2} loan for {1} by the Bank {2}", loanRequest.Amount, loanRequest.Purpose, this.GetType().Name);                  
            }
            else if (this.Successor != null)
            {
                this.Successor.ApproveRequest(loanRequest);
            }
        }
    }
}
