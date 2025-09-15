namespace MathLib;

public class Calculator
{
    // Method to add two numbers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Overloaded method to add an array of integers
    public int Add(int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
    
    // Method to get two numbers from the console and display the maximum
    public void GetMaxFromConsoleInput()
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