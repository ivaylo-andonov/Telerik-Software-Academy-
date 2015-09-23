namespace TemplateMethodHirePeopleDemo
{
    using System;

    public class CustomerSupportDepartment : HiringProcess
    {
        protected override void CaseSolving()
        {
            Console.WriteLine("Writing an article about Communication with difficult clients");
        }

        protected override void FirstRoundTest()
        {
            Console.WriteLine("Conducted Test in English");
        }
    }
}
