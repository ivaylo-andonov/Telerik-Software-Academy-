namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Abstraction.Validator;

    internal abstract class Course
    {
        private string name;
        private string teacherName;
        private IList<string> students;

        internal Course(string name)
        {
            this.Name = name;
            this.students = new List<string>();
        }

        internal Course(string name, string teacherName)
            : this(name)
        {
            this.TeacherName = teacherName;
            this.students = new List<string>();
        }

        internal string Name 
        {
            get 
            {
                return this.name;
            }

            set 
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Course name can not be an empty string");
                this.name = value;
            }
        }

        internal string TeacherName
        {
            get 
            {
                return this.teacherName;
            }

            private set 
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Teacher name can not be an empty string");
                this.teacherName = value;
            }
        }

        internal IList<string> Students
        {
            get
            {
                return new List<string>(this.students);
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("LocalCourse { Name = ");
            result.Append(this.Name);

            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudents());

            return result.ToString();
        }

        internal void AddStudents(string name)
        {
            Validator.CheckIfStringIsNullOrEmpty(name, "Student name can not be an empty string");
            this.students.Add(name);
        }

        internal void AddStudents(List<string> students)
        {
            foreach (var item in students)
            {
                Validator.CheckIfStringIsNullOrEmpty(item, "Student name can not be an empty string");
                this.students.Add(item);
            }
        }

        internal void AddTeacher(string name)
        {
            this.TeacherName = name;
        }       

        private string GetStudents()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}