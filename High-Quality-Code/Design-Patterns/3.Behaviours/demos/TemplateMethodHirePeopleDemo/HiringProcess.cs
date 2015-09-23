namespace TemplateMethodHirePeopleDemo
{
    using System;

    public abstract class HiringProcess
    {
        public void HirePerson()
        {
            this.FirstRoundTest();
            this.CaseSolving();
            this.HRInterview();
        }

        protected abstract void CaseSolving();

        protected abstract void FirstRoundTest();

        private void HRInterview()
        {
            Console.WriteLine("Interview with the HR and Department Managers");
        }
    }
}
