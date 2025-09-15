// See https://aka.ms/new-console-template for more information
using System;

namespace SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test cases to verify the output
            Console.WriteLine(nTwice("Hello", 2));        // Output: Helo
            Console.WriteLine(nTwice("Chocolate", 3));    // Output: Choate
            Console.WriteLine(nTwice("Chocolate", 1));    // Output: Ce

            // Accept input from user
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();
            
            Console.Write("Enter an integer n: ");
            int n = int.Parse(Console.ReadLine());

            // Call nTwice with user input and display the result
            string result = nTwice(inputString, n);
            Console.WriteLine("Result: " + result);
        }
        
        static string nTwice(string str, int n)
        {
            // Extract the first n characters and the last n characters
            string firstPart = str.Substring(0, n);
            string lastPart = str.Substring(str.Length - n);

            // Return the concatenated result
            return firstPart + lastPart;
        }
    }
}