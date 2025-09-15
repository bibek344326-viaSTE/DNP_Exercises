using System;

class Program
{
    static void Main(string[] args)
    {
        // Example cases
        Console.WriteLine("Example Cases:");
        Console.WriteLine($"CanFastAttack(knightIsAwake: false) → {CanFastAttack(false)}"); // true
        Console.WriteLine($"CanSpy(knightIsAwake: true, archerIsAwake: false) → {CanSpy(true, false)}"); // true
        Console.WriteLine($"CanSignal(prisonerIsAwake: true, archerIsAwake: false) → {CanSignal(true, false)}"); // true
        Console.WriteLine($"CanFree(prisonerIsAwake: true, knightIsAwake: false, archerIsAwake: false, dogIsPresent: false) → {CanFree(true, false, false, false)}"); // true

        // User input mode
        Console.WriteLine("\nInteractive Mode:");
        while (true)
        {
            Console.Write("Is the knight awake? (true/false): ");
            bool knightIsAwake = GetBooleanInput();

            Console.Write("Is the archer awake? (true/false): ");
            bool archerIsAwake = GetBooleanInput();

            Console.Write("Is the prisoner awake? (true/false): ");
            bool prisonerIsAwake = GetBooleanInput();

            Console.Write("Is the dog present? (true/false): ");
            bool dogIsPresent = GetBooleanInput();

            Console.WriteLine($"\nResults:");
            Console.WriteLine($"CanFastAttack → {CanFastAttack(knightIsAwake)}");
            Console.WriteLine($"CanSpy → {CanSpy(knightIsAwake, archerIsAwake)}");
            Console.WriteLine($"CanSignal → {CanSignal(prisonerIsAwake, archerIsAwake)}");
            Console.WriteLine($"CanFree → {CanFree(prisonerIsAwake, knightIsAwake, archerIsAwake, dogIsPresent)}\n");

            Console.Write("Do you want to try another scenario? (yes/no): ");
            if (!Console.ReadLine().Trim().Equals("yes", StringComparison.OrdinalIgnoreCase))
                break;
        }
    }

    // Method to determine if a fast attack is possible
    static bool CanFastAttack(bool knightIsAwake)
    {
        return !knightIsAwake;
    }

    // Method to determine if spying is possible
    static bool CanSpy(bool knightIsAwake, bool archerIsAwake)
    {
        return knightIsAwake || archerIsAwake;
    }

    // Method to determine if signaling the prisoner is possible
    static bool CanSignal(bool prisonerIsAwake, bool archerIsAwake)
    {
        return prisonerIsAwake && !archerIsAwake;
    }

    // Method to determine if the prisoner can be freed
    static bool CanFree(bool prisonerIsAwake, bool knightIsAwake, bool archerIsAwake, bool dogIsPresent)
    {
        return (prisonerIsAwake && !knightIsAwake && !archerIsAwake) || (dogIsPresent && !archerIsAwake);
    }

    // Helper method to get boolean input from the user
    static bool GetBooleanInput()
    {
        while (true)
        {
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "true" || input == "false")
                return bool.Parse(input);
            Console.Write("Invalid input. Please enter 'true' or 'false': ");
        }
    }
}
