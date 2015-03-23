namespace _01.SchoolClasess
{
    using System;
    using System.Text;

    public class Discipline: IComment
    {
        // Fields
        private string name;
        private string comment;
        private int numberOfLectures;
        private int numberOfExercises;

        //Constructors
        public Discipline(string name, int numLectures, int numExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numLectures;
            this.NumberOfExercises = numExercises;
        }

        public Discipline(string name, int numLectures, int numExercises, string comment)
            : this(name, numLectures, numExercises)
        {
            this.Comment = comment;
        }

        // Properties
        public string Name
        {
            get { return this.name; }
            set {
                if (value.Length < 3 || value.Length > 40)
                {
                    throw new ArgumentOutOfRangeException("The name is too strange or unreal.Try again!");
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name is empty!");
                }
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set {
                if (value < 1)
                {
                    throw new ArgumentNullException("The signed lectures should be at least 1");
                }
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentNullException("The signed lectures should be at least 1");
                }
                this.numberOfExercises = value;
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
            result.AppendLine(string.Format("\"{0}\" | Lectures per week: {1} | Exercises per lecture: {2}",this.name,this.numberOfLectures,this.numberOfExercises));
            
            return result.ToString();
        }

    }
}
