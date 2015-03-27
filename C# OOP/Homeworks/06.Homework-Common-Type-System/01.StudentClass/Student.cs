namespace _01.StudentClass
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Generic;

    public class Student: IComparable,ICloneable
    {
        //No Fields , directly automatic properties in this case no sense from validation

        //Constructor
        
        public Student(string firstName, string middleName, string lastName, int SSN, string adress,string mobilePhone,
                        string email,int course ,University university, Specialty speciality, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSNnumber = SSN;
            this.Adress = adress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Specialty = speciality;
            this.Faculty = faculty;
        }

        // Properties
        public string FirstName      { get; private set; }
        public string MiddleName     { get; private set; }
        public string LastName       { get; private set; }
        public int SSNnumber         { get; private set; }
        public string Adress         { get; private set; }
        public string MobilePhone    { get; private set; }
        public string Email          { get; private set; }
        public int Course            { get; private set; }
        public Specialty Specialty   { get; private set; }
        public University University { get; private set; }
        public Faculty Faculty       { get; private set; }


        // Problem 1, Override methods Object.Equals(),Object.GetHashCode() and Object.ToString();

        public override bool Equals(object other)
        {
            var otherStudent = other as Student;           

            return     this.FirstName == otherStudent.FirstName
                    && this.MiddleName == otherStudent.MiddleName
                    && this.LastName == otherStudent.LastName
                    && this.SSNnumber == otherStudent.SSNnumber;
        }

        public override int GetHashCode()
        {
            int hash = 9;
            hash = (hash * 7) + this.SSNnumber.GetHashCode();
            return hash;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(string.Format("Student name: {0} {1} {2}",this.FirstName,this.MiddleName,this.LastName));
            result.Append(string.Format("\nSSN: {0}\nPermanent Adress: {1}\nMobile phone: {2}\nEmail: {3}\nCourse: {4}"
                          ,this.SSNnumber,this.Adress,this.MobilePhone,this.Email,this.Course));
            result.Append(string.Format("\nUniversity: {0}\nSpecialty: {1}\nFaculty: {2}"
                          ,this.University,this.Specialty,this.Faculty));


            return result.ToString();
        }

        // Problem 1 , Override operators ==, != ;
        public static bool operator ==(Student firstStud, Student secondStud)
        {
            return firstStud.Equals(secondStud);
        }

        public static bool operator !=(Student firstStud, Student secondStud)
        {
            return !(firstStud == secondStud);
        }

        // Problem 2
        public object Clone()
        {
            Student originalStudent = this;
            Student newStudent = new Student(originalStudent.FirstName, originalStudent.MiddleName, originalStudent.LastName,
                                originalStudent.SSNnumber,originalStudent.Adress,originalStudent.MobilePhone, originalStudent.Email,
                                originalStudent.Course, originalStudent.University, originalStudent.Specialty, originalStudent.Faculty);

            return newStudent;  // Deep clone
        }

        //Problem 3
        public int CompareTo(object obj)
        {
            Student otherStudent = obj as Student;
            int comparrison = this.FirstName.CompareTo(otherStudent.FirstName);
            if (comparrison == 0)
            {
                return this.SSNnumber.CompareTo(otherStudent.SSNnumber);
            }

            return comparrison;
        }
    }

    public enum Specialty
    {
        Informatics,
        Math, Biology,
        History,
        French,
        Art
    }

    public enum University
    {
        UNSS,
        Harvard,
        SoftUni,
        Caimbrige,
        Oxford
    }

    public enum Faculty
    {
        Faculty1,
        Faculty2,
        Faculty3,
        Beta,
        Alpha,
        Gamma
    } 
}
