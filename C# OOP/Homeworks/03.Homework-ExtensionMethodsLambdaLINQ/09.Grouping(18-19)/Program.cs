using _07.StudentGroups_9_16_;
// Added reference from 07 Project

namespace _09.Grouping_18_19_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            // Create examples 
            List<Student> students = new List<Student>();

            var studentOne = new Student("Ivo", "Andonov", "115115", "0895801888",
                "ivailo.anodnov@abv.bg", new List<double> { 2.0, 3.5, 5.5, 6.0 }, new Group(2, "Mathematics"));
            students.Add(studentOne);

            var studentTwo = new Student("Petar", "Milchev", "115706", "+3598958018444",
               "peshos@hotmail.com", new List<double> { 2.0, 6.0, 6.0, 6.0 }, new Group(3, "Biology"));
            students.Add(studentTwo);

            var studentThree = new Student("Stefan", "Dobrev", "134654", "0895801777",
                "kulevcha@gmail.com", new List<double> { 2.0, 3.5, 3.5 }, new Group(2, "Mathematics"));
            students.Add(studentThree);

            var studentFour = new Student("Kiril", "Ludogorec", "234432", "02-345432",
                "tapir@dir.bg", new List<double> { 6.0, 4.5, 2.0, 4.0, 5.0 }, new Group(1, "Informatics"));
            students.Add(studentFour);

            var studentFive = new Student("Aladin", "Simbatov", "467406", "+35921345111",
               "spasssss@abv.bg", new List<double> { 2.0, 2.0 }, new Group(2, "French"));
            students.Add(studentFive);

            // PROBLEM 18
            var groupedStudents = from student in students
                                  group student by student.GroupNumber.GroupNumber into gr
                                  select new
                                  {
                                      Group = gr.Key,
                                      Students = gr.ToList()
                                  };

            foreach (var grouped in groupedStudents)
            {
                Console.WriteLine("\nGroup: {0} Students:\n---------------------\n{1}", grouped.Group,
                    string.Join("\r\n\r\n", grouped.Students));
            }


            // PROBLEM 19 The same but with extension methods

            var groupedStudents2 = students.GroupBy(x => x.GroupNumber.GroupNumber, (groupNum, studentss) => 
                new { Group = groupNum, Students = studentss });

            //foreach (var grouped in groupedStudents2)
            //{
            //    Console.WriteLine("\nGroup: {0} Students:\n---------------------\n{1}", grouped.Group,
            //        string.Join("\r\n\r\n", grouped.Students));
            //}
        }
    }
}