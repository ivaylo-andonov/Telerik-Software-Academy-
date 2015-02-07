using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        byte SALT = byte.Parse(Console.ReadLine());
        int counter = 0;
        while (true)
        {
            double inputCharNum = Console.Read();
            char inputChar = (char)inputCharNum;
            if (inputChar == '@')
            {
                break;
            }
            if (counter % 2 == 0)
            {
                counter++;
                if (char.IsLetter(inputChar))
                {
                    inputCharNum *= SALT;
                    inputCharNum += 1000;
                    inputCharNum /= 100.00;
                    Console.WriteLine("{0:F2}", inputCharNum);
                }
                else if (char.IsDigit(inputChar))
                {
                    inputCharNum += SALT;
                    inputCharNum += 500;
                    inputCharNum /= 100.00;
                    Console.WriteLine("{0:F2}", inputCharNum);
                }
                else 
                {
                    inputCharNum -= SALT;
                    inputCharNum /= 100.00;
                    Console.WriteLine("{0:F2}", inputCharNum);
                }
            }
            else if (counter % 2 != 0)
            {
                counter++;
                if (char.IsLetter(inputChar))
                {
                    inputCharNum *= SALT;
                    inputCharNum += 1000;
                    inputCharNum *= 100;
                    Console.WriteLine(inputCharNum);
                }
                else if (char.IsDigit(inputChar))
                {
                    inputCharNum += SALT;
                    inputCharNum += 500;
                    inputCharNum *= 100;
                    Console.WriteLine(inputCharNum);     
                }
                else 
                {
                    inputCharNum -= SALT;
                    inputCharNum *= 100;
                    Console.WriteLine(inputCharNum);
 
                }
            }
        }
    }
}

