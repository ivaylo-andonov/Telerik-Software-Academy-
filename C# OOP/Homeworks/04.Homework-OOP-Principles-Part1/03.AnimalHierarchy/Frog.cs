namespace _03.AnimalHierarchy
{
    using System;

    public class Frog : Animal
    {
        //Constructor
        public Frog(string name, int age)    // Frogs don`t have GENDER !
            : base(name,age)       
        { 
        }

        //Method
        public override void MakeSound()
        {
            Console.WriteLine("{0} says \"Ami kakvo kato sym JABA?!\"",this.Name);
        }
    }
}
