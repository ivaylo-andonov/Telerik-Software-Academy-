namespace _02.PersonClass
{
    using System;

    class CheckFunctionality
    {
        static void Main()
        {
            var michael = new Person("Michael Cox", 25);
            var john = new Person("John Bradley");

            Console.WriteLine("{0}\n{1}", michael,john);
        }
    }
}
