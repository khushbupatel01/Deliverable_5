/* Author: Khushbu Patel
 * Date: 2/13/2023
 * Description: This is a C# console app that uses two methods to ask a user to populate an array and to find the sum of the elements of the array.
 */

using System;

namespace Deliverable_5
{
    class Program
    {
        static int[] randomArray(int arrayLen)
        {
            Random random = new Random();
            int[] myArray = new int[arrayLen];
            for (int i = 0; i < arrayLen; i++)
            {
                myArray[i] = random.Next(10, 50);
            }
            return myArray;
        }

        static int sum(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                sum += item;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int input = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter an integer between 5 and 15: ");
                    input = int.Parse(Console.ReadLine());
                    if (input >= 5 && input <= 15)
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter an integer between 5 and 15!");
                }
            }

            int[] sampleArray = randomArray(input);

            Console.WriteLine("The elements in the random array are: ");

            foreach (int element in sampleArray)
            {
                Console.WriteLine(element + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("The sum is: " + sum(sampleArray));
        }
    }
}