using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Numerics;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        decimal[] numbers = new decimal[10000];
        BigInteger digitsProduct = 1;
        BigInteger totalProduct = 1;
        BigInteger digitsProduct2 = 1;
        BigInteger totalProduct2 = 1;
        int numbersCount = 0;
        decimal inputNumber = 0;
        bool isNumber = true;

        do
        {
            isNumber = decimal.TryParse(Console.ReadLine(), out inputNumber);
            numbers[numbersCount] = inputNumber;
            numbersCount++;
        } while (isNumber);

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i < 10)
            {
                if (i % 2 == 1)
                {
                    if (numbers[i] == 0)
                    {
                        continue;
                    }
                    string number = numbers[i].ToString();

                    for (int j = 0; j < number.Length; j++)
                    {
                        if (Char.IsDigit(number[j]))
                        {
                            if (int.Parse(number[j].ToString()) == 0)
                            {
                                continue;
                            }
                            digitsProduct *= int.Parse(number[j].ToString());
                        }
                    }
                    totalProduct *= digitsProduct;
                    digitsProduct = 1;
                }
            }
            else
            {
                if (numbers[i] == 0)
                {
                    continue;
                }
                if (i % 2 == 1)
                {
                    string number = numbers[i].ToString();

                    for (int j = 0; j < number.Length; j++)
                    {
                        if (Char.IsDigit(number[j]))
                        {
                            if (int.Parse(number[j].ToString()) == 0)
                            {
                                continue;
                            }
                            digitsProduct2 *= int.Parse(number[j].ToString());
                        }
                    }
                    totalProduct2 *= digitsProduct2;
                    digitsProduct2 = 1;
                }
            }
        }
        if (numbersCount <= 10)
        {
            Console.WriteLine(totalProduct);
        }
        else
        {
            Console.WriteLine(totalProduct);
            Console.WriteLine(totalProduct2);
        }
    }
}