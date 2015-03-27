namespace _02.BankAccounts
{
    using System;

    public abstract class Account: IDepositable
    {
        // Fields
        private Customer customer;
        private decimal balance;
        private decimal interestRate;
        private DateTime openDate;

        //Constructor
        public Account(Customer customer, decimal balance, decimal rate, DateTime openDate)
        {
            this.Client = customer;
            this.Balance = balance;
            this.InterestRate = rate;
            this.openDate = openDate;  
        }

        //Properties
        public Customer Client
        {
            get { return this.customer; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.customer = value;
            }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set { this.interestRate = value; }
        }

        // Property Months because we have to know how many months existing the account and to calculate after that "InterestAmount"
        public int Months
        {
            get
            {
                return (DateTime.Now.Year * 12 + DateTime.Now.Month) - (this.openDate.Year * 12 + this.openDate.Month);
            }
        }

        // Method implemented because of interface IDepositable
        public void MakeDeposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("You cannot deposite a negative or a zero sum!");
            }

            this.Balance += amount; 
        }

        // Method virtual, because it has common case and suppossed to be implemented and by child classes
        public virtual decimal CalculateInterestAmount()
        {
            return (this.Months * this.InterestRate);
        }

        public override string ToString()
        {
            return string.Format("Owner: {0}\nAccount type: {1}\nBalance: {2:C}\nInterest: {3:C} ",
                this.Client.Name, this.GetType().Name, this.Balance, this.CalculateInterestAmount());
        }

    }
}
