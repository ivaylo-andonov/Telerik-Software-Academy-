using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char a = (char)169;
        
        Console.WriteLine(new string(' ', 3) + a + new string(' ', 3));
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(new string(' ', 2 - 1*i) + a + new string(' ', 1 + 2*i) + a + new string(' ', 2 - 1*i));
        }
        Console.WriteLine("{0} {0} {0} {0}",a);
        Console.WriteLine();

          Console.WriteLine(   @"   ©
  © ©
 ©   ©
© © © ©
");
    }
    
 }