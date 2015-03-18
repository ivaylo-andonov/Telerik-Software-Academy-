//Define a class that holds information about a mobile phone device: 
//model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk)
//and display characteristics (size and number of colors).
//Define 3 separate classes (class GSM holding instances of the classes Battery and Display).

namespace _01.DefineClass
{
    using System;

    class DefineClassMain
    {
        static void Main()
        {
            //Print the Iphone4S Static
            GSMTest.PrintIphone4S();

            // Test the mobile phones specifics, you can change the number of GSM-s from the number in method GeneratorGSM()
            GSMTest.PrintGSMGenerator(GSMTest.GeneratorGSM(3));


            //Problem 12 Solved

            GSMCallHistoryTest.AddTestCallsInHistory();         // Add definited calls from array into the List<Calls>
            GSMCallHistoryTest.DisplayCalltestHistory();       // Print the call history for the moment
            Console.WriteLine(Environment.NewLine);

            GSMCallHistoryTest.CalculateAndPrintTestcallsPrice();  // Calculate and print the price of all calls in the List<Calls) with fixed price 0.37
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("The longest call is removing...");
            GSMCallHistoryTest.RemoveLongestCall();                     // Remove the longest call from the List<Calls>    
            Console.WriteLine(Environment.NewLine);


            Console.WriteLine("After the longest call was removed:");
            Console.WriteLine(Environment.NewLine);

            GSMCallHistoryTest.CalculateAndPrintTestcallsPrice();  // Calculate and print the price of all calls in the List<Calls) with fixed price 0.37
            Console.WriteLine(Environment.NewLine);                // after the removing longest call


            GSMCallHistoryTest.DisplayCalltestHistory();    // Print call history 
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Now the phone calls are clearing from the history...");
            GSMCallHistoryTest.testGSM.ClearCallHistory();      // Clear data history
            Console.WriteLine(Environment.NewLine);

            GSMCallHistoryTest.DisplayCalltestHistory();      // Print empty history
            Console.WriteLine("WELL DONE\n");


        }
    }
}