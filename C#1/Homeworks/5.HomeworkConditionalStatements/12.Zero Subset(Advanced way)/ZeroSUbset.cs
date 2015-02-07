 /* Problem 12.	* Zero Subset
We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
 * Examples:
  
  numbers	  |   result
3  -2  1  1 8 | -2 + 1 + 1 = 0
              |
3 1 -7 35 22  |	no zero subset
              |
1 3 -4 -2 -1  |	 1 + -1 = 0
              |  1 + 3 + -4 = 0
              |  3 + -2 + -1 = 0
 
1 1 1 -1 -1	  |  1 + -1 = 0
              |  1 + 1 + -1 + -1 = 0
  
 0 0 0 0 0	  | 0 + 0 + 0 + 0 + 0 = 0
 */

using System;
using System.Collections.Generic;

class ZeroSubset
{
    static void Main()
    {
        //Make int array with the numbers
        string[] input = Console.ReadLine().Split();
        int[] numbers = new int[input.Length];
        int counter = 0;
        
        // Make a List for checking : Is added the same number`s combination equal to zero before that or no?
        List<string> myList = new List<string>();
       
        // Fill the numbers array
        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        // Check if the sum of all 5 is 0
        if (numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
        }
        
        // Check if every one number is 0
        else if (numbers[0] == 0 && numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] == 0)
        {
            Console.WriteLine("0 + 0 + 0 + 0 + 0 = 0");
        }
        
        // Start to find everyone combination of the numbers equal to zero and put it in the List, if the List contains 
        // that combination before that -> skip the print. Start with loops from 2 ,3 and 4 number`s combination.

        else if (true)
        {
            // Combination with 2 numbers equal to 0
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == 0)
                    {
                        counter++;
                        string subset = string.Format("{0} + {1} = 0", numbers[i], numbers[j]);
                        if (myList.Contains(subset) != true)
                        {
                            Console.WriteLine(subset);
                        }
                        myList.Add(subset);
                    }
                }
            }
            //Combination with 3 numbers equal to 0
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    for (int k = j+1; k < numbers.Length; k++)
                    {
                        if (numbers[i] + numbers[j] + numbers[k] == 0)
                        {
                            counter++;
                            string subset = string.Format("{0} + {1} + {2} =0", numbers[i], numbers[j], numbers[k]);
                            if (myList.Contains(subset) != true)
                            {
                                Console.WriteLine(subset);
                            }
                            myList.Add(subset);
                        }
                    }
                }
            }
            //Combination with 4 numbers equal to 0
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    for (int k = j+1; k < numbers.Length; k++)
                    {
                        for (int m = k+1 ; m < numbers.Length; m++)
                        {
                            if (numbers[i] + numbers[j] + numbers[k] + numbers[m] == 0)
                            {
                                counter++;
                                string subset = string.Format("{0} + {1} + {2} + {3} =0", numbers[i], numbers[j], numbers[k], numbers[m]);
                                if (myList.Contains(subset) != true)
                                {
                                    Console.WriteLine(subset);
                                }
                                myList.Add(subset);
                            }
                        }
                    }
                }
            }
            // If there aren`t any  combinations equal to 0 , - zero subset
            if (counter < 1)
            {
                Console.WriteLine("zero subset ");
            }
        }
    }
}



