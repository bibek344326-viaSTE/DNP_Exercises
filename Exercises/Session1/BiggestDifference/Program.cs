using System;

namespace BiggestDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test cases to verify the output
            Console.WriteLine(biggestDifference(new int[] { 10, 3, 5, 6 }));    // Output: 7
            Console.WriteLine(biggestDifference(new int[] { 7, 2, 10, 9 }));    // Output: 8
            Console.WriteLine(biggestDifference(new int[] { 2, 10, 7, 2 }));    // Output: 8

            // Accept input from user
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Call biggestDifference with user input and display the result
            int result = biggestDifference(numbers);
            Console.WriteLine("Result: " + result);
        }
        
        static int biggestDifference(int[] numbers)
        {
            // Find the maximum and minimum values in the array
            int max = numbers[0];
            int min = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
            }

            // Calculate the difference between the maximum and minimum values
            return max - min;
        }
    }
}

