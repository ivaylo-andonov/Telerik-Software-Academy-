namespace _01.StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TestStudentClass
    {
        public static void Main()
        {
            // Examples
            Student studentIvan = new Student("Ivan", "Manolov", "Kodev", 1175443445, "ul.Asenevci N3, Shumen", "+359895888333", "i.kodev@gmail.com", 3, University.Oxford, Specialty.French, Faculty.Alpha);
            Student studentDimcho = new Student("Dimcho", "Buhov", "Kostov", 1145345682, "ul.Padashti kotki, Sopot", "+359895123123", "Malkiq_Muk@gmail.com", 1, University.Harvard, Specialty.Biology, Faculty.Faculty3);

            // Crate array of Students
            Student[] students = new Student[] { studentIvan,studentDimcho};

            // Print
            Console.WriteLine("All students:\n");
            foreach (var student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }

            // Check the overrited methods
            Console.WriteLine("\nIs Ivan == Dimcho?\n");
            Console.WriteLine(studentIvan == studentDimcho);

            Console.WriteLine("\nIs Ivan != Dimcho?\n");
            Console.WriteLine(studentIvan != studentDimcho);

            Console.WriteLine("\nIs Ivan equal to Dimcho?\n");
            Console.WriteLine(studentIvan.Equals(studentDimcho));

            Console.WriteLine("\nIvan compared with Dimcho:\n");
            Console.WriteLine(studentIvan.CompareTo(studentDimcho));

            Console.WriteLine("\nIvan HashCode:\n");
            Console.WriteLine(studentIvan.GetHashCode());
            Console.WriteLine("\nDimcho HashCode:\n");
            Console.WriteLine(studentDimcho.GetHashCode());

            Console.WriteLine("\nDimcho is copied...\n");
            var studentDimcho2 = studentDimcho.Clone();                         // Deep clone/sopy , element by element

            Console.WriteLine("\nIs DImcho compared with copied Dimcho?\n");
            Console.WriteLine(studentDimcho.CompareTo(studentDimcho2));

            Console.WriteLine("\nIs Dimcho equals to copied Dimcho?\n");
            Console.WriteLine(studentDimcho.Equals(studentDimcho2));           // Should be true

            Console.WriteLine("\nIs Dimcho equals to copied Dimcho by reference?\n");
            Console.WriteLine(ReferenceEquals(studentDimcho2,studentDimcho)); // Should be false
            Console.WriteLine("\nNice!");



            



        }
    }
}
