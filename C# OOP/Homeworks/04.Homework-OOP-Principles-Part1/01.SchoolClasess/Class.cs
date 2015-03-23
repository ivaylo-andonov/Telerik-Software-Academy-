namespace _01.SchoolClasess
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class Class: IComment
    {
        //Fields               
        private string comment;
        private string textIdentifer;
        private List<Teacher> teachers;
        private List<Student> students;

        //Constructor

        public Class(string textIdentifer)
        {
            this.textIdentifer = textIdentifer;
            this.teachers = new List<Teacher>();
            this.students = new List<Student>();
        }

        public Class(string textIdentifer, string comment)
            : this(textIdentifer)
        {
            this.comment = comment;
        }

        // Propertis
        public string TextIdentifier
        {
            get
            {
                return this.textIdentifer;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Class identifier cannot be empty!");
                }
                
                this.textIdentifer = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return new List<Teacher>(this.teachers);
            }
        }

        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        //Methods
        public void AddStudentToAClass(Student student)
        {
            this.students.Add(student);
        }

        public void AddTeacherToAClass(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("   -<<< Class \"{0}\" >>>-\n     -< Students: {1} >-",this.textIdentifer,this.students.Count));
            for (int i = 0; i < this.students.Count; i++)
            {
                result.AppendFormat("{0}",this.students[i]);

            }
            result.AppendFormat("\n      -< Teachers : {0} >-\n", this.teachers.Count);
            for (int i = 0; i < this.teachers.Count; i++)
            {
                result.AppendLine(string.Format("\n{0}", this.teachers[i]));
            }

            return result.ToString();
        }
    }
}
