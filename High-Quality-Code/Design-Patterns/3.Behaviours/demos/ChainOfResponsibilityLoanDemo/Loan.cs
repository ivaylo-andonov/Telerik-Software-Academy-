namespace ChainOfResponsibilityLoanDemo
{
    /// <summary>
    /// Class holding request details
    /// </summary>
    internal class Loan
    {
        public Loan(string purpose, decimal amount)
        {
            this.Purpose = purpose;
            this.Amount = amount;
        }

        public string Purpose { get; set; }

        public decimal Amount { get; set; }        
    }
}
