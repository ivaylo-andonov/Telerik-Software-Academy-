namespace _01.SchoolClasess
{
    using System;

    public abstract class Person
    {
        //Field
        private string name;

        // Constructor
        public Person(string name)
        {
            this.Name = name;
        }

        //Property
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
                    throw new ArgumentNullException("The name is Empty!");
                }
                this.name = value;
            }
        }
    
    }
}
