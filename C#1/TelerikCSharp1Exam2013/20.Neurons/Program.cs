using System;
using System.Linq;

//1) Безкраен цикъл, докато потребителят въвежда числа различни от -1.
//2) Конвертираме всяко подадено n в двоична бройна система и го присвояваме на масива от символи.
//3) Търсим индекса на най-левият бит, който е единица
//4) Търсим индекса на най-десният бит, който е единица
//5) Итерираме елементите на number от индекса на най-левия бит до индекса на най-десния бит, 
//   като разменяме единиците с нули и нулите с единици.
//6) Конвертираме масива към string, след това към десетична бройна система и принтирам резултата.

class Neurons
{
    static void Main()
    {
        while (true)
        {
            long n = long.Parse(Console.ReadLine());
            if (n == -1) break;

            char[] number = Convert.ToString(n, 2).ToArray();

            int leftOne = Array.IndexOf(number, '1');
            int rightOne = Array.LastIndexOf(number, '1');

            if (leftOne != -1)
                for (int j = leftOne; j <= rightOne; j++)
                    number[j] = (number[j] == '1') ? '0' : '1';

            Console.WriteLine(Convert.ToInt32(string.Join(string.Empty, number), 2));
        }

        //while(true)
        //    {
        //        long line = long.Parse(Console.ReadLine());
        //        if (line == -1)
        //        {
        //            break;
        //        }

        //        int mostLeftIndex = -1;
        //        int mostRightIndex = -1;
        //        for (int p = 0; p < 32; p++)
        //        {
        //            long mask = 1 << p;
        //            long nAndMask = line & mask;
        //            long bit = nAndMask >> p;
        //            if (bit == 1)
        //            {
        //                if (mostRightIndex == -1)
        //                {
        //                    mostRightIndex = p;
        //                }

        //                mostLeftIndex = p;
        //            }
        //        }

        //        if (mostLeftIndex == -1)
        //        {
        //            Console.WriteLine(0);
        //            continue;
        //        }

        //        long result = 0;
        //        for (int p = mostRightIndex; p <= mostLeftIndex; p++)
        //        {
        //            long mask = 1 << p;
        //            long nAndMask = line & mask;
        //            long bit = nAndMask >> p;
        //            if (bit == 0)
        //            {
        //                result = result | mask;
        //            }
        //        }

        //        Console.WriteLine(result);
        //    }
        //} 

    }
}
