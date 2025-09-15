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
}