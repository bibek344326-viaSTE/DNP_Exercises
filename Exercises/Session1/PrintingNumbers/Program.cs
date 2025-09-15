// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    { // Taking input for 'x' from the user
        Console.Write("Enter a number (x): ");
        int x = int.Parse(Console.ReadLine());

        // Taking input for 'y' from the user
        Console.Write("Enter a number (y) for divisibility check: ");
        int y = int.Parse(Console.ReadLine());

        // Calling methods with user input
        Console.WriteLine($"\nEven numbers between 0 and {x}:");
        PrintEvenNumbers(x);

        Console.WriteLine($"\nUneven (odd) numbers between 0 and {x}:");
        PrintUnevenNumbers(x);

        Console.WriteLine($"\nNumbers divisible by {y} between 0 and {x}:");
        PrintNumbersDivisibleBy(x, y);  }
    
    static void PrintEvenNumbers(int x)
    {
        for (int i = 0; i <= x; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine(); // For a clean new line after printing
    }

// Method to print uneven (odd) numbers
    static void PrintUnevenNumbers(int x)
    {
        for (int i = 0; i <= x; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine(); // For a clean new line after printing
    }

// Method to print numbers divisible by y
    static void PrintNumbersDivisibleBy(int x, int y)
    {
        for (int i = 0; i <= x; i++)
        {
            if (i % y == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine(); // For a clean new line after printing
    }

}


