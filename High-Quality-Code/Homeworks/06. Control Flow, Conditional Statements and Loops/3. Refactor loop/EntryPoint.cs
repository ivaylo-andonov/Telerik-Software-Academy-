namespace RefactorLoop
{
    using System;

    public static class EntryPoint
    {
        public static void Main()
        {
            bool[] array = new bool[] { true, false, true };

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(array[i]);

                if (i % 10 == 0 && array[i])
                {
                    Console.WriteLine("Value Found");
                    break;
                }
            }
        }
    }
}
