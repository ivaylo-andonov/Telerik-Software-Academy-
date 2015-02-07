using System;

class StringAndObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object helloWorld = hello + " " + world;
        string greeting = (string)helloWorld;
        Console.WriteLine("{0}\n{1}",  helloWorld, greeting);


    }
}
    