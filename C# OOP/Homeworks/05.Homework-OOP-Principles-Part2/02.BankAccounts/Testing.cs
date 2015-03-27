namespace _02.BankAccounts
{
    using System;

    class Testing
    {
        static void Main()
        {
            Bank bank = new Bank("TD Bank USA");

            Customer firstOwner = new Customer("Ivaylo", CustomerType.Individuals);
            Deposit myDeposit = new Deposit(firstOwner, 6400, 23.55m,new DateTime(2010,05,28));
            bank.AddAccount(myDeposit);

            Customer secondOwner = new Customer("Telerik", CustomerType.Companies);
            Mortgage telerikLoanAccount = new Mortgage(secondOwner, 245000000, 34.88m,new DateTime(2006,10,20));
            bank.AddAccount(telerikLoanAccount);

            Console.WriteLine(bank);

            for (int i = 0; i < bank.AllAccounts.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Account {0}: ", i + 1);
                Console.WriteLine(bank.AllAccounts[i]);
            }

            decimal withdrawAmount = 1200M;
            decimal depositAmount = 20000M;

            myDeposit.WithDraw(withdrawAmount);
            telerikLoanAccount.MakeDeposit(depositAmount);

            Console.WriteLine("\nToday {0} withdraw {1:C} from his account, and now {0} has {2:C}"
                ,myDeposit.Client.Name,withdrawAmount,myDeposit.Balance);

            Console.WriteLine("\nToday {0} make a deposit {1:C} into his account, and now {0} has {2:C}"
                , telerikLoanAccount.Client.Name, depositAmount, telerikLoanAccount.Balance);

        }
    }
}
