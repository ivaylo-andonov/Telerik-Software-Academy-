namespace _02.BankAccounts
{
    using System;

    public class Customer
    {
        //Fields
        private string name;
        private CustomerType type;

        //Constructor
        public Customer(string name, CustomerType type)
        {
            this.Name = name;
            this.Type = type;
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
                    throw new ArgumentException("The name cannot be null!");
                }
                this.name = value;
            }
        }

        public CustomerType Type
        {
            get
            {
                return this.type;
            }
            private set
            {
                this.type = value;
            }
        }
    }
}
