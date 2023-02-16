using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deliverable_5_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user to enter an integer between 5 and 15
            Console.Write("Enter an integer between 5 and 15: ");

            int arrayLength = 0;

            try
            {
                // Try to parse the user's input as an integer
                arrayLength = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                // If the user's input is not an integer, display an error message and then exit
                Console.WriteLine("Invalid input. Please enter an integer between 5 and 15.");
                return;
            }

            // If the user's input is outside the range of 5 to 15, display an error message and then exit
            if (arrayLength < 5 || arrayLength > 15)
            {
                Console.WriteLine("Invalid input. Please enter an integer between 5 and 15.");
                return;
            }

            // Generate an array of random integers with a equal length to user input
            int[] array = GenerateRandomArray(arrayLength);

            // Display the elements of the array in the console
            Console.Write("The elements of the array are: ");
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Calculate the sum of the elements in the array
            int sum = SumArray(array);

            // Display the sum in the console
            Console.WriteLine("The sum is: " + sum);

            // Pause the console so the user can read output
            Console.ReadLine();
        }

        // Method for generating an array of random integers
        static int[] GenerateRandomArray(int length)
        {
            int[] array = new int[length];
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                // Generate a random integer between 10 and 50 and add it to the array
                array[i] = random.Next(10, 51);
            }
            return array;
        }

        // Method for computing the sum of an array of integers
        static int SumArray(int[] array)
        {
            int sum = 0;
            foreach (int number in array)
            {
                // Add each element of the array to the sum
                sum += number;
            }
            return sum;
        }
    }
}