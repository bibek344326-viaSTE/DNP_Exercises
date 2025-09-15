using System;

namespace SurroundWith;

class Program
{
    static void Main()
    {
        // Test cases to verify the output
        Console.WriteLine(makeOutWord("<<>>", "Yay"));     // Output: <<Yay>>
        Console.WriteLine(makeOutWord("<<>>", "WooHoo"));  // Output: <<WooHoo>>
        Console.WriteLine(makeOutWord("[[]]", "word"));    // Output: [[word]]
            
        // Accept input from user
        Console.Write("Enter the outer string (length 4): ");
        string outer = Console.ReadLine();
        Console.Write("Enter the word: ");
        string word = Console.ReadLine();

        // Call makeOutWord with user input and display the result
        string result = makeOutWord(outer, word);
        Console.WriteLine("Result: " + result);
    }
    static string makeOutWord(string outer, string word)
    {
        // Concatenate the first two characters of outer, word, and the last two characters of outer
        return outer.Substring(0, 2) + word + outer.Substring(2);
    }
    
}

