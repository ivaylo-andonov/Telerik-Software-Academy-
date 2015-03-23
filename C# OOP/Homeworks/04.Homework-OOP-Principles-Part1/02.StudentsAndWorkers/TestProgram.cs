namespace _02.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class TestProgram
    {
        static void Main()
        {
            var allStudents = InitializeStudents();
            var allWorkers = InitializeWorkers();

            var sortedStudents = SortStudentsByGrade(allStudents);
            Console.WriteLine("Students sorted by their grade: ");
            PrintResult(sortedStudents);

            Console.WriteLine();

            var sortedWorkers = SortWorkersByMPHDescending(allWorkers);
            Console.WriteLine("Workers sorted by money per hour earned: ");
            PrintResult(sortedWorkers);

            Console.WriteLine();

            List<Human> mergedList = MergeTwoLists(sortedStudents, sortedWorkers);
            List<Human> orderedHumans = OrderHumansByFirstAndLastName(mergedList);
            Console.WriteLine("Students and workers sorted by their first and last names: ");
            PrintHumans(orderedHumans);
        }


        private static void PrintResult<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.Write("- {0}", item);
            }
        }

        private static void PrintHumans(IEnumerable<Human> orderedHumans)
        {
            foreach (var human in orderedHumans)
            {
                Console.WriteLine("- {0} {1}", human.FirstName, human.LastName);
            }
        }

        private static List<Human> OrderHumansByFirstAndLastName(IEnumerable<Human> mergedList)
        {
            var result = mergedList.OrderBy(x => x.FirstName)
                                   .ThenBy(x => x.LastName)
                                   .ToList();

            return result;
        }

        private static List<Human> MergeTwoLists(IEnumerable<Student> sortedStudents, IEnumerable<Worker> sortedWorkers)
        {
            List<Human> result = new List<Human>();

            result.AddRange(sortedStudents);
            result.AddRange(sortedWorkers);

            return result;
        }

        private static List<Worker> SortWorkersByMPHDescending(IEnumerable<Worker> allWorkers)
        {
            var result = allWorkers.OrderByDescending(x => x.CalculateMoneyPerHour())
                                   .ToList();

            return result;
        }

        private static List<Student> SortStudentsByGrade(IEnumerable<Student> allStudents)
        {
            var result = allStudents.OrderBy(x => x.Grade)
                                    .ToList();

            return result;
        }

        private static List<Worker> InitializeWorkers()
        {
            List<Worker> allWorkers = new List<Worker>();

            allWorkers.Add(new Worker("Dragan", "Draganov", 403, 8));
            allWorkers.Add(new Worker("Blagoi", "Blagoev", 400, 8));
            allWorkers.Add(new Worker("Daniela", "Danielova", 450, 6));
            allWorkers.Add(new Worker("Mario", "Petrov", 500, 12));
            allWorkers.Add(new Worker("Vasil", "Vasilev", 400, 6));
            allWorkers.Add(new Worker("Peicho", "Peichev", 500, 8));
            allWorkers.Add(new Worker("Ivan", "Petrov", 250, 6));
            allWorkers.Add(new Worker("Georgi", "Petrov", 200, 8));
            allWorkers.Add(new Worker("Reni", "Georgieva", 600, 8));
            allWorkers.Add(new Worker("Gergana", "Georgieva", 750, 6));

            return allWorkers;

        }

        private static List<Student> InitializeStudents()
        {
            List<Student> allStudents = new List<Student>();

            allStudents.Add(new Student("Peter", "Petrov", 10));
            allStudents.Add(new Student("Georgi", "Georgiev", 12));
            allStudents.Add(new Student("Penka", "Penkova", 9));
            allStudents.Add(new Student("Ivan", "Ivanov", 5));
            allStudents.Add(new Student("Stamat", "Stamatov", 9));
            allStudents.Add(new Student("Moisei", "Moiseev", 8));
            allStudents.Add(new Student("Pencho", "Penchev", 7));
            allStudents.Add(new Student("Hristo", "Hristov", 11));
            allStudents.Add(new Student("Krasimir", "Krasimirov", 7));
            allStudents.Add(new Student("Maria", "Petrova", 4));

            return allStudents;
        }
        
    }
}
