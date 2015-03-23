namespace _07.StudentGroups_9_16_
{
    using System;

    public class Group
    {

        public Group(int number, string name)
        {
            this.GroupNumber = number;
            this.DepartmentName = name;
        }

        public int GroupNumber { get; private set; }
        public string DepartmentName { get; private set; }

        public override string ToString()
        {
            return string.Format("Group number: {0}\nDepartment : {1}",
                this.GroupNumber,this.DepartmentName);
        }

    }
}
