using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        StringBuilder str = new StringBuilder();

        if (number == 0)
        {
            Console.WriteLine("LON+");
        }

        while (number > 0)
        {
            ulong digit = number % 9;
            switch (digit)
            {
                case 0: str.Insert(0, "LON+");  break;
                case 1: str.Insert(0, "VK-");   break;
                case 2: str.Insert(0, "*ACAD"); break;
                case 3: str.Insert(0, "^MIM");  break;
                case 4: str.Insert(0, "ERIK|"); break;
                case 5: str.Insert(0, "SEY&");  break;
                case 6: str.Insert(0, "EMY>>"); break;
                case 7: str.Insert(0, "/TEL");  break;
                case 8: str.Insert(0, "<<DON"); break;
            }
            number /= 9;
        }
        
        Console.WriteLine(str.ToString());
    }
}

