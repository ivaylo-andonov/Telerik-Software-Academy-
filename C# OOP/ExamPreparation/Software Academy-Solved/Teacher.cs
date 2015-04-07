namespace SoftwareAcademy
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Generic;

    public class Teacher: ITeacher
    {        
        private string name;
        private ICollection<ICourse> courses;

        public Teacher(string name)
        {
            this.Name = name;
            this.courses = new List<ICourse>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                this.name = value;
            }
        }

        public void AddCourse(ICourse course)
        {
            this.courses.Add(course);
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(string.Format("Teacher: Name={0}",this.Name));
            if (this.courses.Count > 0)
            {
                result.Append(string.Format("; Courses=[{0}]",string.Join(", ",this.courses.Select(x => x.Name))));
            }

            return result.ToString();
        }
    }
}
