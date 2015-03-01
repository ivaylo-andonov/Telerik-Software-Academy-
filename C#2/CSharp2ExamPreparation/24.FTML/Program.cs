using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();

            int closeTagBeg = line.IndexOf("</");

            while (closeTagBeg != -1)
            {
                int closeTagEnd = line.IndexOf(">", closeTagBeg + 1);
                string tagName = line.Substring(closeTagBeg + 2,closeTagEnd - closeTagBeg);

                closeTagEnd = line.IndexOf("<", closeTagEnd + 1);
            }
        }
    }
}

