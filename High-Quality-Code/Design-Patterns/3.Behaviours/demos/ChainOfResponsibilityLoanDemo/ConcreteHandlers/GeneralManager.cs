namespace ChainOfResponsibilityLoanDemo
{
    using System;

    internal class GeneralManager : LoanHandler
    {
        private const decimal ApproveLimit = 2500000M;

        public override void ApproveRequest(Loan loanRequest)
        {
            if (loanRequest.Amount < ApproveLimit)
            {
                Console.WriteLine("Approved {0:C2} loan for {1} by the Bank {2}", loanRequest.Amount, loanRequest.Purpose, this.GetType().Name);
            }
            else 
            {
                Console.WriteLine("Your request for {0} needs to be discussed at a board meeting", loanRequest.Purpose);
            }
        }
    }
}
