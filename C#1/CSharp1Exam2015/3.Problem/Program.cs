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
            string inputText = Console.ReadLine();
            if (inputText == "END")
            {
                break;
            }
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            if (counter < 10)
            {
                
                if (counter % 2 != 0)
                {
                    BigInteger digit = input % 10;
                    if (digit == 0)
                    {
                        digit = 1;
                    }
                    produkt *= digit;
                    input /= 10;
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
                    BigInteger digit = input % 10;
                    if (digit == 0)
                    {
                        digit = 1;
                    }
                    produkt2 *= digit;
                    input /= 10;
                    counter++;
                }
                else if (counter % 2 == 0)
                {
                    counter++;
                }
                smallerThan10 = false;
            }
        }
        if (smallerThan10 == true )
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
