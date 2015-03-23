namespace _03.AnimalHierarchy
{
    using System;

    public class Cat: Animal
    {
        //Constructor
        public Cat(string name, int age,Gender gender)
            : this(name,age)       
        {
            this.Gender = gender;
        }

        public Cat(string name, int age)
            : base(name, age)
        { }


        //Method
        public override void MakeSound()
        {
            Console.WriteLine("{0} says \"Cherni kotaracii s lyskavi mustacii\", Meauww!",this.Name);
        }

    }
}
