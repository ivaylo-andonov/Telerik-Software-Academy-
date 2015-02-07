using System;
using System.Text;

class PrintASCII
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        for (int i = 0; i < 255; i++)
        {
            char c = (char)i;
            Console.Write(c + " ");
        }
     }
}