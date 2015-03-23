namespace _02.StudentsAndWorkers
{
    using System;
    using System.Text;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        // Constructor
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        //Property
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name is Empty!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name is Empty!");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(string.Format("{0} {1}", this.FirstName, this.LastName));

            return result.ToString();
        }
    }
}
