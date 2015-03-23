namespace _01.SchoolClasess
{
    using System;
    using System.Text;

    public class Student : Person,IComment
    {
        //Field
        private string uniqueClassNumber;
        private string comment;

        //Constructor, inhirate the base constructor from tha abstract class parrent (Person)
        public Student(string name, string classNumber)
            : base(name)
        {
            this.ClassNum = classNumber;
        }

        public Student(string name, string classNumber, string comment)
            : this(name, classNumber)
        {
            this.Comment = comment;
        }

        // Property
        public string ClassNum
        {
            get { return this.uniqueClassNumber; }

            private set
            {
                if (value.Length < 1 )
                {
                    throw new ArgumentException("The class number should be greater than 0");
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The class number cannot stays empty!");
                }
                this.uniqueClassNumber = value;
            }
        }

        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("\nStudent name: {0} | Class number: {1}", this.Name, this.uniqueClassNumber));

            return result.ToString();
        }
    }
}
