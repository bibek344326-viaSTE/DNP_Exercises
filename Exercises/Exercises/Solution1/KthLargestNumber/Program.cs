// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Predefined examples
        Console.WriteLine("Predefined Test Cases:");
        Console.WriteLine(Largest(new int[] { 6, 3, 5, 9, 1, 2 }, 2)); // Output: 6
        Console.WriteLine(Largest(new int[] { 6, 3, 5, 9, 1, 2 }, 1)); // Output: 9
        Console.WriteLine(Largest(new int[] { 1, 3, 0, 4, 2, 1, 3 }, 4)); // Output: 1

        Console.WriteLine("\nAdditional Test Cases:");
        Console.WriteLine(Largest(new int[] { 10, 20, 30, 40, 50 }, 3)); // Output: 30
        Console.WriteLine(Largest(new int[] { -1, -5, -3, -2 }, 2)); // Output: -2

        // User input
        Console.WriteLine("\nUser Input Mode:");
        while (true)
        {
            try
            {
                Console.Write("Enter the array elements separated by spaces (or type 'exit' to quit): ");
                string input = Console.ReadLine();

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    break;

                int[] array = input.Split(' ').Select(int.Parse).ToArray();

                Console.Write("Enter the value of k: ");
                int k = int.Parse(Console.ReadLine());

                Console.WriteLine($"The {k}-th largest number is: {Largest(array, k)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
    static int Largest(int[] ints, int k)
    {
        // Check if k is valid
        if (k > ints.Length || k <= 0)
        {
            throw new ArgumentException("Invalid value for k: larger than array length or less than 1.");
        }

        // Sort the array in descending order
        int[] sortedArray = ints.OrderByDescending(n => n).ToArray();

        // Return the k-th largest element (0-indexed)
        return sortedArray[k - 1];
    }
}