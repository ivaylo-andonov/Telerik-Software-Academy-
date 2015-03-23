namespace _03.AnimalHierarchy
{
    using System;

    public class Tomcat : Cat
    {
        //Constructor
        public Tomcat( string name,int age)
            : base(name,age)
        {
            Gender Gender = Gender.Male;
        }
    }
}
