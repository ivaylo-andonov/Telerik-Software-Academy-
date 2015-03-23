namespace _01.SchoolClasess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainSchoolClasses
    {
        static void Main()
        {

            // Just examples :)
            School school = new School("Proffesional Economy College");

            Class firstClass = new Class("11 B");
            Class secondClass = new Class("10 A");
            Class thirdClass = new Class("12 D");

            Teacher firstTeacher = new Teacher("Pesho");
            Teacher secondTeacher = new Teacher("Gosho");

            Student firstStudent = new Student("Maria", "13");
            Student secondStudent = new Student("Penka", "2");
            Student thirdStudent = new Student("Blagoi", "32");
            Student forthStudent = new Student("Krasimir", "7");
            Student fifthStudent = new Student("Ivan", "15");

            Discipline math = new Discipline("Maths", 5, 10);
            Discipline history = new Discipline("History", 3, 6);
            Discipline geography = new Discipline("Geography", 3, 6);
            Discipline literature = new Discipline("Literature", 2, 4);

            school.AddClass(firstClass);
            school.AddClass(secondClass);
            school.AddClass(thirdClass);

            firstTeacher.AddDiscipline(math);
            firstTeacher.AddDiscipline(literature);
            secondTeacher.AddDiscipline(history);
            secondTeacher.AddDiscipline(geography);

            firstClass.AddStudentToAClass(firstStudent);
            firstClass.AddStudentToAClass(secondStudent);
            secondClass.AddStudentToAClass(thirdStudent);
            thirdClass.AddStudentToAClass(forthStudent);
            thirdClass.AddStudentToAClass(fifthStudent);

            firstClass.AddTeacherToAClass(firstTeacher);
            firstClass.AddTeacherToAClass(secondTeacher);
            secondClass.AddTeacherToAClass(firstTeacher);
            thirdClass.AddTeacherToAClass(secondTeacher);


            Console.WriteLine(school);
        }
    }
}
