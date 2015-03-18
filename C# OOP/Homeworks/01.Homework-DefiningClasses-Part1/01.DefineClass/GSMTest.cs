namespace _01.DefineClass
{
    using System;
    using System.Collections.Generic;

    public class GSMTest
    {
        public static Random gsmRandom = new Random();

        public static string[] owners = { "Ivan", "Pesho", "Ivaylo", "Doncho", "Niki", "Evlogi", "Pavlaka", "SHmekera","Canko Ludiq","Penka"};

        public static string[,] models = 
        {
           {"One X" ,"Galaxy S6","Nexus 4","Razer", "Iphone 6 Plus", "Lumnia","Xperia Z", "Z7" , "C720"},
           {"Desire" ,"Galaxy S4","Nexus 5","Z8", "Iphone 3", "1100","X8", "G6" , "Torch Q10"},
           {"Diamond" ,"Galaxy S5","Nexus 6","Z7", "Iphone 5S", "6600","Xperia S", "Len8" , "C1000"},
        };

        public static Battery[] batteries =
        {
            new Battery(),
            new Battery(BatteryType.NiMH,67,12),
            new Battery(BatteryType.Li_Po,8,4),
            new Battery(BatteryType.Li_Ion,48,12)
        };

        public static Display[] displays = 
        { 
            new Display(),
            new Display(11.4,6.7,16000000),
            new Display(8.4,4.5,8000000),
            new Display(16.5,6.6,32000000)
        };

        public static GSM[] GeneratorGSM(int numberGSMs)
        {
            GSM[] gsms = new GSM[numberGSMs];
           
            for (int i = 0; i < numberGSMs; i++)
            {
                int manufacturerIndex = gsmRandom.Next(0, 9);

                gsms[i] = new GSM(models[gsmRandom.Next(models.GetLength(0)),manufacturerIndex],
                                 (Manufacturer)manufacturerIndex, gsmRandom.Next(6,2100),
                                 owners[gsmRandom.Next(0,owners.Length)],
                                 displays[gsmRandom.Next(0,displays.Length)],
                                 batteries[gsmRandom.Next(0,batteries.Length)]);                                  
            }
            return gsms;       
        } 
      
        public static void PrintGSMGenerator(GSM[] mobiles)
        {
            foreach (var gsm in mobiles)
            {
                Console.WriteLine(gsm.ToString());
            }
        }

        public static void PrintIphone4S()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(GSM.Iphone4S);
            Console.ResetColor();
        }
    }
}
