namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Bank
    {
        //Fields
        private string name;
        private IList<Account> allAccounts;

        //Constructors
        public Bank(string name)
        {
            this.Name = name;
            this.allAccounts = new List<Account>();
        }

        //Properties
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name of the bank cannot be null!");
                }

                this.name = value;
            }
        }

        internal IList<Account> AllAccounts
        {
            get
            {
                return new List<Account>(this.allAccounts);
            }
        }

        //Methods
        public void AddAccount(Account newAccount)
        {
            this.allAccounts.Add(newAccount);
        }

        public override string ToString()
        {
            return string.Format("The Bank \"{0}\"\nOpened accounts: {1}", this.Name, this.AllAccounts.Count);
        }
    }
}
