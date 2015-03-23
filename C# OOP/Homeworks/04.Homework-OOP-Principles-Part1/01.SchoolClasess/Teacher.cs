namespace _01.SchoolClasess
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class Teacher : Person,IComment
    {
        //Fields
        private List<Discipline> disciplines;
        private string comment;

        //Constructors
        public Teacher(string name)
            : base(name)
        {
            this.disciplines = new List<Discipline>();
        }

        public Teacher(string name, string comment)
            : this(name)
        {
            this.Comment = comment;
        }

        // Property , its require to be implemented from interface IComment
        public string Comment
        { 
            get { return this.comment;}
            set {this.comment = value;}
        }

        public List<Discipline> Disciplines
        {
            get { return new List<Discipline>(this.disciplines); }
        }

        //Methods
        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Teacher name: {0}\nDisciplines:\n", this.Name);
            for (int i = 0; i < this.disciplines.Count; i++)
            {
                result.Append(string.Format("\n - {0}",this.disciplines[i]));
            }

            return result.ToString();
        }
    }
}
