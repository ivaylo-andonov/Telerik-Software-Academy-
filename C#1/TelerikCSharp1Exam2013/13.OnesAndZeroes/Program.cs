using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnesAndZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string numStr = Convert.ToString(num, 2).PadLeft(16, '0');
            char[] arr = numStr.ToCharArray();
            string binary = "";
            if (arr.Length > 16)
            {
                char[] newArr = new char[16];
                Array.Reverse(arr);
                for (int i = 0; i < 16; i++)
                {
                    newArr[i] = arr[i];
                }
                Array.Reverse(newArr);
                binary = new string(newArr);
            }
            else
            {
                binary = new string(arr);
                binary = binary.PadLeft(16, '0');
            }

            string[] one = new string[5];
            string[] zero = new string[5];
            one[0] = ".#.";
            one[1] = "##.";
            one[2] = ".#.";
            one[3] = ".#.";
            one[4] = "###";
            zero[0] = "###";
            zero[1] = "#.#";
            zero[2] = "#.#";
            zero[3] = "#.#";
            zero[4] = "###";

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    int m = binary[j] - '0';
                    if (m == 0)
                    {
                        Console.Write(zero[i]);
                    }
                    else if (m == 1)
                    {
                        Console.Write(one[i]);
                    }
                    if (j < 15)
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}