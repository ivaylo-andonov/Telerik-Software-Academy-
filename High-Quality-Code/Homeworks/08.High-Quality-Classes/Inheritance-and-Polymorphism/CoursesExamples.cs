namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    internal class CoursesExamples
    {
        internal static void Main()
        {
            LocalCourse localCourse = new LocalCourse("Databases");
            Console.WriteLine(localCourse);

            localCourse.AddLab("Enterprise");
            Console.WriteLine(localCourse);

            localCourse.AddStudents(new List<string>() { "Peter", "Maria" });
            Console.WriteLine(localCourse);

            localCourse.AddTeacher("Svetlin Nakov");
            localCourse.AddStudents("Milena");
            localCourse.AddStudents("Todor");
            Console.WriteLine(localCourse);

            OffsiteCourse offsiteCourse = new OffsiteCourse(
                "PHP and WordPress Development", "Mario Peshev");
            offsiteCourse.AddStudents(new List<string>() { "Thomas", "Ani", "Steve" });
            Console.WriteLine(offsiteCourse);
        }
    }
}
