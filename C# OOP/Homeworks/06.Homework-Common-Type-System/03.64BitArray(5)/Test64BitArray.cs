namespace _03._64BitArray_5_
{
    using System;

    class Test64BitArray
    {
        static void Main()
        {
            BitArray64 arrayOne= new BitArray64(3u);
            BitArray64 arrayTwo = new BitArray64(150u);

            Console.WriteLine("Binary number one:");
            Console.WriteLine(arrayOne);
            Console.WriteLine("Binary number two:");
            Console.WriteLine(arrayTwo);

            arrayOne[0] = 0;
            arrayTwo[0] = 1;

            Console.WriteLine("Binary number one changed:");
            Console.WriteLine(arrayOne);
            Console.WriteLine("Binary number two changed:");
            Console.WriteLine(arrayTwo);

            Console.WriteLine("\nNumber one == number two?");
            Console.WriteLine(arrayOne == arrayTwo);

            Console.WriteLine("\nNumber one is equal to itself?");
            Console.WriteLine(arrayOne.Equals(arrayOne));

            Console.WriteLine("\nNumber one !- number two?");
            Console.WriteLine(arrayOne != arrayTwo);

            Console.WriteLine("\nThe bit with index [2] of number one is:");
            Console.WriteLine(arrayOne[2]);

            Console.WriteLine("\nThe bit with index [2] of number two is:");
            Console.WriteLine(arrayTwo[2]);
        }
    }
}
