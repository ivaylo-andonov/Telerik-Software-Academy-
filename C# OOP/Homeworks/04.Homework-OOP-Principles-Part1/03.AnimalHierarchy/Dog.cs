namespace _03.AnimalHierarchy
{
    using System;

    public class Dog : Animal
    {
        //Constructor
        public Dog(string name, int age,Gender gender)
            : this(name,age)       
        {
            this.Gender = gender;
        }

        public Dog(string name, int age)
            : base(name, age)
        { }

        //Method
        public override void MakeSound()
        {
            Console.WriteLine("{0} says \"Woof MF wooof mf!\"",this.Name);
        }
    }
}
