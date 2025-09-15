// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Generate a random string
        string randomString = GenerateRandomString();
        Console.WriteLine($"Generated String: {randomString}");

        // Find sums between question marks
        FindSums(randomString);    }

    // Method A: GenerateRandomString()
    static string GenerateRandomString()
    {
        Random random = new Random();
        char[] characters = "abcdefghijklmnopqrstuvwxyz0123456789?".ToCharArray();
        char[] result = new char[20];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = characters[random.Next(characters.Length)];
        }

        return new string(result);
    }

    // Method B: FindSums(string s)
    static void FindSums(string s)
    {
        List<int> sums = new List<int>();
        int currentSum = 0;

        foreach (char c in s)
        {
            if (c == '?')
            {
                // Add the current sum to the list and reset for the next segment
                sums.Add(currentSum);
                currentSum = 0;
            }
            else if (char.IsDigit(c))
            {
                // Add numeric value to the current sum
                currentSum += c - '0';
            }
        }

        // Add the last sum if the string does not end with `?`
        if (currentSum > 0)
        {
            sums.Add(currentSum);
        }

        // Print results
        Console.WriteLine("Sums:");
        Console.WriteLine(string.Join(", ", sums));
    }
}