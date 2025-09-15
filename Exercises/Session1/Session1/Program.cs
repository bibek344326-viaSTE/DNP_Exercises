using System;

namespace ABBA
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(makeABBA("Hi", "Bye"));
              Console.WriteLine(makeABBA("Yo", "Alice"));
                Console.WriteLine(makeABBA("What", "Up"));
                Console.WriteLine(makeABBA("Foo", "Bar"));
                
                // Ask for the first string
                Console.Write("Enter the first string: ");
                string a = Console.ReadLine();

                // Ask for the second string
                Console.Write("Enter the second string: ");
                string b = Console.ReadLine();

                // Call makeAbba and display the result
                string result = makeABBA(a, b);
                Console.WriteLine("Result: " + result);
        }

        static string makeABBA(string a, string b)
        {
            return a + b + b + a;
        }
    }
}