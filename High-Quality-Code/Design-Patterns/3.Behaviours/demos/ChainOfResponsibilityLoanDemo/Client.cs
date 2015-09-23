namespace ChainOfResponsibilityLoanDemo
{
    using System;

    public class Client
    {
        public static void Main()
        {
            LoanHandler lowLevelClerk = new Clerk();
            LoanHandler midLevelManager = new AssistanManager();
            LoanHandler topExecuive = new GeneralManager();

            lowLevelClerk.SetSuccessor(midLevelManager);
            midLevelManager.SetSuccessor(topExecuive);

            var loan = new Loan("New Laptop", 1999);
            lowLevelClerk.ApproveRequest(loan);

            loan = new Loan("Fancy Sport Car", 180000);
            lowLevelClerk.ApproveRequest(loan);

            loan = new Loan("House in Miami", 1750000);
            lowLevelClerk.ApproveRequest(loan);

            loan = new Loan("Shiny Yacht", 12000000);
            lowLevelClerk.ApproveRequest(loan);
        }
    }
}
