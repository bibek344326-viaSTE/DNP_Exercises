// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

static class Program
{
    static void Main(string[] args)
    {
        // Predefined examples
        Console.WriteLine("Predefined Examples:");
        Console.WriteLine($"1 → {NumberToWords(1)}");
        Console.WriteLine($"157 → {NumberToWords(157)}");
        Console.WriteLine($"23831 → {NumberToWords(23831)}");
        Console.WriteLine($"999999 → {NumberToWords(999999)}");
        Console.WriteLine($"1000000000 → {NumberToWords(1000000000)}");

        // User Input Mode
        Console.WriteLine("\nNow, test with your own inputs:");
        while (true)
        {
            Console.Write("Enter a number (or type 'exit' to quit): ");
            string? input = Console.ReadLine();

            if (input != null && input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                break;

            if (long.TryParse(input, out long number) && number >= 0 && number <= 999_999_999_999)
            {
                Console.WriteLine($"{number} → {NumberToWords(number)}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 999,999,999,999.");
            }
        } 
    }
    static string NumberToWords(long number)
    {
        if (number == 0)
            return "zero";

        if (number < 0)
            return "minus " + NumberToWords(Math.Abs(number));

        string[] unitsMap = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", 
            "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

        string[] tensMap = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        string words = "";

        if ((number / 1_000_000_000) > 0)
        {
            words += NumberToWords(number / 1_000_000_000) + " billion ";
            number %= 1_000_000_000;
        }

        if ((number / 1_000_000) > 0)
        {
            words += NumberToWords(number / 1_000_000) + " million ";
            number %= 1_000_000;
        }

        if ((number / 1_000) > 0)
        {
            words += NumberToWords(number / 1_000) + " thousand ";
            number %= 1_000;
        }

        if ((number / 100) > 0)
        {
            words += NumberToWords(number / 100) + " hundred ";
            number %= 100;
        }

        if (number > 0)
        {
            if (words != "")
                words += "and ";

            if (number < 20)
                words += unitsMap[number];
            else
            {
                words += tensMap[number / 10];
                if ((number % 10) > 0)
                    words += "-" + unitsMap[number % 10];
            }
        }

        return words.Trim();
    }
    
}