//Write a program to convert binary numbers to hexadecimal numbers (directly).

﻿using System;
using System.Collections.Generic;

class BinToHex
{
    static void Main()
    {
        List<string> hex = new List<string>()   {"0000", "0001", "0010", "0011", 
                                                 "0100", "0101", "0110", "0111",
                                                 "1000", "1001", "1010", "1011",
                                                 "1100", "1101", "1110", "1111"};
        Console.Write("Enter any binary digit: ");
        string input = Console.ReadLine().ToUpper();
        if (input.Length % 4 > 0)
            input = new string('0', 4 - (input.Length % 4)) + input;    // make sting lehght divisible by 4
        // 01 -> 0001, 10 -> 0010
        string result = "";
        int index = 0;
        for (int i = 0; i < input.Length / 4; i++)
        {
            string s1 = input.Substring(i * 4, 4);
            index = hex.IndexOf(s1);
            if (index == -1)
            {
                Console.WriteLine("Invalid input. Execution terminated.");
                return;
            }
            if (index < 10)
                result = result + (char)(index + 48);
            else
                result = result + (char)(index + 55);
        }
        Console.WriteLine("Hexadecimal representation ot binary number {0} is 0x{1}", input, result);
    }
}