namespace _02.BankAccounts
{
    using System;

    public class Deposit : Account,IWithDrawable
    {
        // Constructor
        public Deposit(Customer customer, decimal balance, decimal rate,DateTime openDate)
            : base(customer, balance, rate,openDate)
        {
 
        }

        //Method override virtual method ClaculateInterestAmount() from parent clas Account
        public override decimal CalculateInterestAmount()
        {
            if (this.Balance < 1000)
            {
                return 0;
            }

            return base.CalculateInterestAmount();
        }

        // Method comes from IWithDrawable interface
        public void WithDraw(decimal withdrawedSum)
        {
            if (withdrawedSum <= 0)
            {
                throw new ArgumentException("You cannot withdraw a negative or a zero sum!");
            }

            this.Balance -= withdrawedSum;
        }
    }
}
