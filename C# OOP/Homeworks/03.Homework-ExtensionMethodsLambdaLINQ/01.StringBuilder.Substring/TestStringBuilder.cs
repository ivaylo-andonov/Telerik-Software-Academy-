namespace _01.StringBuilder.Substring
{
    using System;
    using System.Text;

    class TestStringBuilder
    {
        static void Main(string[] args)
        {
            StringBuilder testBuilder = new StringBuilder();
            Console.WriteLine("Full text:\n");
            testBuilder.Append("Hey my friend, have you done with your third homework ?");
            Console.WriteLine(testBuilder);
            testBuilder = testBuilder.Substring(15, 13);
            Console.WriteLine("\nChoosen substring:\n");
            Console.WriteLine(testBuilder);
        }
    }
}
