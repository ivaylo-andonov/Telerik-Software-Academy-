namespace _07.Text_To_Xml
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    class Program
    {
        static void Main()
        {
            var person = new Person();

            using (StreamReader reader = new StreamReader("../../person-info.txt"))
            {
                person.Name = reader.ReadLine();
                person.Age = reader.ReadLine();
                person.Adress = reader.ReadLine();
                person.PhoneNumber = reader.ReadLine();
            }

            var personElement = new XElement("person",
                new XElement("name", person.Name),
                new XElement("age", person.Age),
                new XElement("adress", person.Adress),
                new XElement("phone", person.PhoneNumber));
         
            personElement.Save("../../person.xml");
            Console.WriteLine("Task 07.");
            Console.WriteLine("New person.xml file is created in main directory.");
        }
    }
}
