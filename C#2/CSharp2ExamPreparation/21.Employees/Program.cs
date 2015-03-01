using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Rank { get; set; }
    public string Position { get; set; }
}

class Program
{
    static void Main()
    {
        int numberPositions = int.Parse(Console.ReadLine());

        var positions = new Dictionary<string, int>();
        for (int i = 0; i < numberPositions; i++)
        {
            string[] line = Console.ReadLine().Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
            if (!positions.ContainsKey(line[0]))
            {
                string position = line[0];
                int rank = int.Parse(line[1]);
                positions.Add(position, rank);
            }
        }
        int numberEmpoyees = int.Parse(Console.ReadLine());
        List<Employee> allEmployees = new List<Employee>();

        for (int i = 0; i < numberEmpoyees; i++)
        {
            string[] line = Console.ReadLine().Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
            string[] name = line[0].Split();

            Employee currentEmployee = new Employee();
            currentEmployee.FirstName = name[0];
            currentEmployee.LastName = name[1];
            currentEmployee.Position = line[1];
            currentEmployee.Rank = positions[currentEmployee.Position];

            allEmployees.Add(currentEmployee);
        }

        var sortedEMployees = allEmployees.OrderByDescending(x => x.Rank).ThenBy(x => x.LastName).ThenBy(x => x.FirstName);
        foreach (var employee in sortedEMployees)
        {
            Console.WriteLine("{0} {1}",employee.FirstName,employee.LastName);
        }
    }
}

