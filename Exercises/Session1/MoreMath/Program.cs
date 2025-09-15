// See https://aka.ms/new-console-template for more information

using MathLib;

class Program
{
    static void Main(string[] args)
    {
        // Prompt user for the first number
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        // Prompt user for the second number
        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Determine the maximum of the two numbers
        int max = Math.Max(num1, num2);

        // Display the result
        Console.WriteLine("The maximum of {0} and {1} is: {2}", num1, num2, max);
    }
}