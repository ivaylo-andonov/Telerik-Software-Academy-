namespace ChainOfResponsibilityLoanDemo
{
    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>
    internal abstract class LoanHandler
    {
        protected LoanHandler Successor { get; set; }

        public void SetSuccessor(LoanHandler successor)
        {
            this.Successor = successor;
        }

        public abstract void ApproveRequest(Loan loanRequest);
    }
}
