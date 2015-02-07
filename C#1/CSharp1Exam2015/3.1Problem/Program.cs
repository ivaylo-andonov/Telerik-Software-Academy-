using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger produkt = 1;
        BigInteger produkt2 = 1;
        BigInteger counter = 0;
        bool smallerThan10 = false;
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            if (counter < 10)
            {
                if (counter % 2 != 0)
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == '0')
                        {
                            input = input.Replace('0', '1');
                        }
                        produkt *= (input[i] - 48);
                    }
                    counter++;
                }
                else if (counter % 2 == 0)
                {
                    counter++;
                }
                smallerThan10 = true;
            }
            else if (counter >= 10)
            {
                if (counter % 2 != 0)
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == '0')
                        {
                            input = input.Replace('0', '1');
                        }
                        produkt2 *= (input[i] - 48);
                    }
                    counter++;
                }
                else if (counter % 2 == 0)
                {
                    counter++;
                }
                smallerThan10 = false;
            }
        }
        if (smallerThan10 == true)
        {
            Console.WriteLine(produkt);
        }
        else if (smallerThan10 == false)
        {
            Console.WriteLine(produkt);
            Console.WriteLine(produkt2);
        }
    }
}
