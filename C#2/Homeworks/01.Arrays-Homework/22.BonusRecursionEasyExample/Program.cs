using System;
// Variations with N elements and N length

class NestedFors
{
    public static void Recursion(int[] arr, int n = 0)
    {
        if (n == arr.Length)
        {
            Console.Write(string.Join(", ", arr));
            Console.WriteLine("; ");
            return;
        }
        for (int i = 1; i <= arr.Length; i++)
        {
            arr[n] = i;
            Recursion(arr, n + 1);
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Recursion(arr);
    }
}
