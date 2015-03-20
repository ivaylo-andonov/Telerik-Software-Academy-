namespace _04.VersionAttribute
{
    using System;
    [Version("v. 2.10")]

    class TestAttribute
    {
        static void Main()
        {
            Type type = typeof(TestAttribute);
            object[] attr = type.GetCustomAttributes(false);
            foreach (VersionAttribute item in attr)
            {
                Console.WriteLine(item.Version);
            }
        }
    }
}