namespace _01.SchoolClasess
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class School
    {
        //Fields
        private string name;
        private List<Class> classes;

        //Constructor
        public School(string name)
        {
            this.Name = name;
            this.classes = new List<Class>();
        }

        //Properties
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
                    throw new NullReferenceException("The school's name cannot be null!");
                }
                this.name = value;
            }
        }

        public List<Class> Classes
        {
            get
            {
                return new List<Class>(this.classes);
            }
        }

        //Method
        public void AddClass(Class someClass)
        {
            this.classes.Add(someClass);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("========== School \"{0}\" ==========\n",this.name));
            foreach (var classs in classes)
            {
                result.AppendLine(string.Format("{0}",classs));
            }

            return result.ToString();
        }
    }
}
