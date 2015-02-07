//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.WriteLine("Enter a company name: ");
        string companyName = (Console.ReadLine());
        Console.WriteLine("Enter a company address: ");
        string companyAddres = (Console.ReadLine());
        Console.WriteLine("Enter a phone number : ");
        string phoneNumber = (Console.ReadLine());
        Console.WriteLine("Enter a fax number : ");
        string faxNumber = (Console.ReadLine());
        Console.WriteLine("Enter a website : ");
        string website = (Console.ReadLine());
        Console.WriteLine("Enter manager`s first name : ");
        string managerFirstName = (Console.ReadLine());
        Console.WriteLine("Enter manager`s last name : ");
        string managerLastName = (Console.ReadLine());
        Console.WriteLine("Enter manager`s age : ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter manager`s phone : ");
        string managerPhone = (Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("{0}\nAdress: {1}\nTel. {2}\nFax: {3}\nWebsite: {4}\nManager: {5} {6} (age: {7}, tel.{8} )", companyName, companyAddres, phoneNumber,
            faxNumber, website, managerFirstName, managerLastName, managerAge, managerPhone);
        Console.WriteLine();

    }
}

