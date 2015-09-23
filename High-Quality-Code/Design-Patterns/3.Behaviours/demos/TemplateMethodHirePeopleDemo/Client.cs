namespace TemplateMethodHirePeopleDemo
{
    using System;

    public class Client
    {
        public static void Main()
        {
            Console.WriteLine("--- How to hire Developer ---");
            HiringProcess newDev = new DotNetDepartment();
            newDev.HirePerson();

            Console.WriteLine("--- How to hire Customer Support ---");
            HiringProcess newSupport = new CustomerSupportDepartment();
            newSupport.HirePerson();
        }
    }
}
