namespace _02.PersonClass
{
    using System;
    using System.Text;

    public class Person
    {
    
        // Fields
        private string name;
        private int? age;

        // Constructor
        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        // Properties
        public string Name
        {
            get { return this.name; }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name is empty.");
                }
                this.name = value;
            }
        }
        public int? Age
        {
            get { return this.age; }
            private set 
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("The age should be between 1 and 100");
                }
                this.age = value;
            }
        }

        //Method ToString()
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("Name: {0}, Age: {1}",this.name,this.age == null? "No info for age": this.age.ToString());

            return sb.ToString();
        }
    }
}
