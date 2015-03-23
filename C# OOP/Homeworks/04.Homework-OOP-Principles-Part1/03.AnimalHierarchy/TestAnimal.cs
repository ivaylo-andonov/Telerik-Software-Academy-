namespace _03.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class TestAnimal
    {
        static void Main()
        {
            Dog[] dogsArray = {
                                  new Dog("Sharo",8, Gender.Male),
                                  new Dog("Maro",1, Gender.Male),
                                  new Dog("Sara",7, Gender.Female),
                                  new Dog("Mara",4, Gender.Female)
                              };

            Cat[] catsArray = {
                                  new Kitten( "Maria",7 ),
                                  new Kitten( "Penka",1 ),
                                  new Tomcat( "Ivo" ,8 ),
                                  new Tomcat( "Tom" ,6 )
                              };

            Frog[] frogsArray = {
                                    new Frog( "Kyrmit",2),
                                    new Frog( "Doncho",5),
                                    new Frog( "Unufri", 3)
                                };

            List<Animal> allAnimals = new List<Animal>();
            allAnimals.AddRange(dogsArray);
            allAnimals.AddRange(catsArray);
            allAnimals.AddRange(frogsArray);

            Console.WriteLine("Average age of dogs in the array is: {0} years.", CalculateAverageYears(dogsArray));
            Console.WriteLine("Average age of cats in the array is: {0} years.", CalculateAverageYears(catsArray));
            Console.WriteLine("Average age of frogs in the array is: {0} years.", CalculateAverageYears(frogsArray));

            Console.WriteLine(Environment.NewLine);

            dogsArray[0].MakeSound();
            catsArray[0].MakeSound();
            frogsArray[0].MakeSound();
                      
        }
        private static double CalculateAverageYears(Animal[] collection)
        {
            double averageAge = collection.Average(x => x.Age);

            return Math.Round(averageAge, 2);
        }
    }
}
