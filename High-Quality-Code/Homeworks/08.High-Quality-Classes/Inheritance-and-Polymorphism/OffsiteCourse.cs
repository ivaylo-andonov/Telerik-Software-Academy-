namespace InheritanceAndPolymorphism
{
    using System.Text;

    using Abstraction.Validator;

    internal class OffsiteCourse : Course
    {
        private string town;

        public OffsiteCourse(string courseName)
            : base(courseName)
        {
        }

        public OffsiteCourse(string courseName, string teacherName)
            : base(courseName, teacherName)
        {
        }

        public OffsiteCourse(string courseName, string teacherName, string town)
            : base(courseName, teacherName)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Town can not be an empty string");
                this.town = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());

            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }

            result.Append(" }");
            return result.ToString();
        }

        internal void AddTown(string townName)
        {
            this.Town = townName;
        }
    }
}
