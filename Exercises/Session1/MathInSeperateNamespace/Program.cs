// See https://aka.ms/new-console-template for more information

using MathLib;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Calculator class
        Calculator calculator = new Calculator();

        // Call the Add method with two numbers
        int sum1 = calculator.Add(5, 10);
        Console.WriteLine("Sum of 5 and 10: " + sum1);

        // Call the overloaded Add method with an array of numbers
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum2 = calculator.Add(numbers);
        Console.WriteLine("Sum of array {1, 2, 3, 4, 5}: " + sum2);
    }
}
