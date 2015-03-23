namespace _03.AnimalHierarchy
{
    using System;

    public class Kitten : Cat
    {
        //Constructor
        public Kitten( string name,int age)
            : base(name,age)
        {
            Gender Gender = Gender.Female;
        }
    }
}
