namespace _02.GenericClass_5_7_
{
    using System;

    class GenericTest
    {
        static void Main()
        {
            // Example shows how it works GenericList. You can change everything.

            GenericList<int> myList = new GenericList<int>();
            Console.WriteLine("--------GenericList--------");
            Console.WriteLine("Capacity: {0} , Count: {1} ",myList.Capacity,myList.Count);

            // Test Count,Capacity and Add
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Adding 20 elements...\n");
            for (int i = 0; i < 20; i++)
            {
                myList.Add(i + 5);
            }

            Console.WriteLine("--------GenericList--------");
            Console.WriteLine("Capacity: {0} , Count: {1} ", myList.Capacity, myList.Count);
            Console.WriteLine(myList);

            //Test  RemoveAt ,InsertAt and FIndIndex
            myList.InsertAtPosition(5, 1111);
            myList.InsertAtPosition(6, 2222);
            myList.InsertAtPosition(7, 3333);

            myList.RemoveByIndex(10);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("--------GenericList--------");
            Console.WriteLine("Capacity: {0} , Count: {1} ", myList.Capacity, myList.Count);
            Console.WriteLine(myList);
            Console.WriteLine("\nThe element {0} is at {1} position.", 3333,myList.IndexOf(3333));

            //Test Min and Max
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Min element is {0}",myList.Min());
            Console.WriteLine("Max element is {0}", myList.Max());
            Console.WriteLine();

        }
    }
}
