namespace _07.StudentGroups_9_16_
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string FN;
        private string tel;
        private string email;
        private List<double> marks;
        private Group groupNumber;

        public Student(string firstName, string lastName, string fn, string tel, string email, List<double> marks, Group group)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.FN = fn;
            this.email = email;
            this.marks = new List<double>(marks);
            this.groupNumber = group;
            this.tel = tel;
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name is empty!");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name is empty!");
                }
                this.lastName = value;
            }
        }

        public string Tel
        {
            get { return this.tel; }
            private set
            {
                if (string.IsNullOrEmpty(value) || (value[0] != '+' && value[0] != '0'))
                {
                    throw new ArgumentException("Tel. cannot be null or empty and must start with + or 0");
                }
                this.tel = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            private set
            {
                if (!this.email.Contains('@') || !this.email.Contains('.'))
                {
                    throw new ArgumentException("Invald email");
                }
                this.email = value;
            }
        }

        public List<double> Marks
        {
            get { return this.marks; }
            private set { this.marks = value; }
        }

        public Group GroupNumber
        {
            get { return this.groupNumber; }
            private set { this.groupNumber = value; }
        }

        public string FacNumber
        {
            get { return this.FN; }
            private set
            {               
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Faculty number cannot be empty");
                }
                this.FN = value;
            }
        }

        public override string ToString()
        {
            return string.Format("First name: {0}\nLast name: {1}\nFaculty number: {2}\n" +
                                 "Group number: {3}\nMarks: {4}\nPhone: {5}\nEmail: {6}",
                this.firstName, this.lastName, this.FN, this.groupNumber,
                string.Join(", ", this.marks), this.tel, this.email);
        }
    }
}
