//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ExtractBitFromInt
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");          
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a position of bit");
        int p = int.Parse(Console.ReadLine());
        int nRightp = n >> p;
        int bit = nRightp & 1;
        Console.WriteLine(bit);
    }
}           
            // Second way with operator ?: and mask//

          // int num = int.Parse(Console.ReadLine());
          // int position = int.Parse(Console.ReadLine());
         // int Mask = 1;
        // Console.WriteLine((mask << position) & num) == 0 ? "0" : "1");


   