namespace _03.FirstBeforeLast
{
// 03.FIRST BEFORE LAST
// Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
// Use LINQ query operators.

// 04. Age range
// Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

// 05. Order students
// Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students 
// by first name and last name in descending order.
// Rewrite the same with LINQ.

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Test
    {
        public static void Main()
        {
            Student[] arrayOfStudents =
            {
                new Student("Ivan", "Petrov", 22),
                new Student("Gosho", "Obretenov", 12),
                new Student("Gosho", "Zahariev", 20),
                new Student("Georgi", "Atanassov", 23),
                new Student("Stamat", "Dimitrov", 17),
                new Student("Ivaylo", "Kenov", 18),
                new Student("Nikolai", "Kostov", 26),
                new Student("Doncho", "Minkov", 32),
                new Student("Evlogi", "Hristov", 25)
            };

            Console.WriteLine("All students:\n");
            foreach (var item in arrayOfStudents)
            {
                Console.WriteLine(item);
            }

            // 3 problem First name before Last name alphibetically with method

            Console.WriteLine("\nStudents whose first name is before their last alphabetically:\n");

            PrintCollection(SelectByFirstNameBeforeLastName(arrayOfStudents));

            // 4 problem AGE RANGE with LINQ

            var selectedByAge = arrayOfStudents.Where(x => x.Age >= 18 && x.Age <= 24).ToArray();

            Console.WriteLine("\nStudents whose age is between 18 - 24:\n");
            PrintCollection(selectedByAge);

            // 5 Problem Order Students

            Console.WriteLine("\nStudents sorted by first name,than by last name in descending order\n");

            var sortedByFirstAndLastNameDesc = arrayOfStudents.OrderByDescending(x => x.FirstName).ThenBy(x => x.LaststName);
            PrintCollection(sortedByFirstAndLastNameDesc);
        }

        
        // 3 Problem Created Method
        private static IEnumerable<Student> SelectByFirstNameBeforeLastName(IEnumerable<Student> collection)
        {
            var result = collection.Where(x => x.FirstName[0] < x.LaststName[0]).ToArray();
            return result;
        }

        // Print method
        public static void PrintCollection(IEnumerable<Student> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

    }
}
