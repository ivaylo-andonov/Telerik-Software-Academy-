namespace TemplateMethodHirePeopleDemo
{
    using System;

    public class DotNetDepartment : HiringProcess
    {
        protected override void CaseSolving()
        {
            Console.WriteLine("Implementing Template method design pattern");
        }

        protected override void FirstRoundTest()
        {
            Console.WriteLine("Taking a tricky test in C#");
        }
    }
}
