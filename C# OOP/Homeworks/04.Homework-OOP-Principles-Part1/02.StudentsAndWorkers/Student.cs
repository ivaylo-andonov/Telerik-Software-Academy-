namespace _02.StudentsAndWorkers
{
    using System;
    using System.Text;

    public class Student: Human
    {
        private int grade;

        public Student(string firstName, string secondName, int grade)
            : base(firstName, secondName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get {return this.grade ;}
            private set { this.grade = value; }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("{0} is in {1} grade", base.ToString(), this.Grade));

            return result.ToString();
        }
    }
}
