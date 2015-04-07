namespace SoftwareAcademy
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Generic;

    public abstract class Course : ICourse
    {
        private string name;
        private ICollection<string> topics;

        protected Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.topics = new List<string>();
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

        public ITeacher Teacher { get; set; }

        public void AddTopic(string topic)
        {
            this.topics.Add(topic);
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(string.Format("{0}: Name={1};", this.GetType().Name, this.Name));
            if (this.Teacher != null)
            {
                result.Append(string.Format(" Teacher={0};",this.Teacher.Name));
            }
            if (this.topics.Count > 0)
            {
                result.Append(string.Format(" Topics=[{0}];",string.Join(", ",this.topics)));
            }

            return result.ToString();
        }
    }
}
