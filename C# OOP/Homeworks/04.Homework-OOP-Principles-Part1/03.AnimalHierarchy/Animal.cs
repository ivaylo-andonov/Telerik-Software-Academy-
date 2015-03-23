namespace _03.AnimalHierarchy
{
    using System;

    public abstract class Animal: ISound
    {
        // Fields
        private int age;
        private string name;
        private Gender gender;

        //Constructors
        public Animal(string name, int age) 
        {
            this.Name = name;
            this.Age = age;
        }
        public Animal(string name, int age, Gender gender)
            : this(name, age)
        {
            this.Gender = gender;
        }

        //Properties
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                this.name = value;
            }
        }        

        public int Age
        {
            get { return this.age; }
            set
            {
                if (age < 0)
                {
                    throw new ArgumentException("Age cannot be negative");
                }
                this.age = value;
            }
        }

        public Gender Gender { get { return this.gender; } protected set { this.gender = value; } }


        // Methods | make it abstract to be inhireted and implemented by child classes

        public virtual void MakeSound()
        {
            Console.WriteLine("Pss");
        }
        
    }
}
