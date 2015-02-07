using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Georgi";
        string middleName = "Ivanov";
        string lastName = "Kovchazov";
        decimal balance = 32.400M ;
        string bankName = "Post Bank";
        string IBAN = "BG56009A334839C949";
        long creditCardOne = 3452995543320076;
        long creditCardTwo = 4453234288654569;
        long creditCardThree = 669948534347732;

        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}",
            firstName,middleName,lastName,balance,bankName,IBAN,creditCardOne,creditCardTwo,creditCardThree);
        
    }
}