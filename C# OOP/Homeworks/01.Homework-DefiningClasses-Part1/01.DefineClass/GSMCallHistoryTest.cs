namespace _01.DefineClass
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class GSMCallHistoryTest   // Problem 12
    {
        public const double fixedCallPrice = 0.37;

        public static GSM testGSM = new GSM();  // Create instance of GSM class

        public static Call[] testCalls = 
        {
            new Call(new DateTime(2015,03,11,23,40,15),"+359889633234", 5.9),
            new Call(new DateTime(2015,03,11,15,30,15),"+359886053922", 40 ),
            new Call(new DateTime(2015,03,11,12,38,15),"+359888363333", 22.3 ),
            new Call(new DateTime(2015,03,11,17,45,15),"+359888443464", 6.7 ),
            new Call(new DateTime(2015,03,11,22,30,15),"+359888457475", 50.7 )
        };

        public static void AddTestCallsInHistory()
        {
            for (int i = 0; i < testCalls.Length; i++)
            {
                testGSM.AddCalls(testCalls[i]);   // Using AddCalls method from GSM class, doesn`t use this because testGSM is STATIC
            }
        }

        public static void DisplayCalltestHistory()
        {
            if (testGSM.CallHistory.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Call history is EMPTY");
            }
            else
            {
                Console.WriteLine(testGSM.PrintCallHistory()); //using method of the GSM class

            }
            Console.ResetColor();
        }

        public static void CalculateAndPrintTestcallsPrice()
        {
            double price = testGSM.CalculateTotalPrice();                     //using method of the GSM class
            Console.WriteLine("Total price of test calls: {0:C}", price);
        }

        public static void RemoveLongestCall()        
        {
            Call theLongestCall = testGSM.CallHistory.OrderBy(x => x.Duration).Last();  // Take the longest call from the list of calls
            testGSM.RemoveCalls(theLongestCall);                                        // using method from GSM class
        }
    }
}
