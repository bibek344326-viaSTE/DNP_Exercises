// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Predefined test cases
        string[] examples = new string[]
        {
            "mr owl ate my metal worm",
            "do geese see god",
            "was it a car or a cat i saw",
            "murder for a jar of red rum",
            "123454321",
            "this is not a palindrome",
            "hello world",
            "No lemon, no melon"
        };

        Console.WriteLine("Predefined Test Cases:");
        foreach (var example in examples)
        {
            Console.WriteLine($"\"{example}\" → {IsPalindrome(example)}");
        }

        Console.WriteLine("\nNow, test your own input:");
        while (true)
        {
            Console.Write("Enter a string (or type 'exit' to quit): ");
            string input = Console.ReadLine();

            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                break;

            Console.WriteLine($"\"{input}\" → {IsPalindrome(input)}");
        }    // True

    }
    
    // Method to check if a string is a palindrome
    static bool IsPalindrome(string input)
    {
        // Remove spaces and convert to lowercase
        string sanitized = input.Replace(" ", "").ToLower();

        // Use two pointers to check for palindrome
        int left = 0;
        int right = sanitized.Length - 1;

        while (left < right)
        {
            if (sanitized[left] != sanitized[right])
            {
                return false; // Not a palindrome
            }
            left++;
            right--;
        }

        return true; // Is a palindrome
    }
}