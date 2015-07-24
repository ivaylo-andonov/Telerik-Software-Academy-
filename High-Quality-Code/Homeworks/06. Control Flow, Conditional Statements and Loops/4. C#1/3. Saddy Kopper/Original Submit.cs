using System;
using System.Numerics;

class Saddy_Kopper
{
    static void Main()
    {
        //Console.Write("Enter number: ");
        string num = Console.ReadLine();

        BigInteger sum = 0;
        BigInteger product = 1;
        decimal trans = 0;

        while (true)
        {

            for (int j = 0; j < num.Length-1; j++)
            {

                for (int i = 0; i < num.Length - j -1; i += 2)  //calc sums of digits
                {
                    sum += (BigInteger)(num[i] - 48);
                }

                product *= sum;  //product for all nums
                sum = 0;
            }

            num = product.ToString();
            product = 1;
            trans++;
            if (num.Length < 2 || trans > 9) break;
        }

        if (trans>9)
        {
            Console.WriteLine(num);
        }
        else
        {
            Console.WriteLine(trans);
            Console.WriteLine(num);
        }
    }
}