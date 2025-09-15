using System;

namespace ArrayClumps
{
    class Program
    {
        static void Main()
        {// Test cases to verify the output
            Console.WriteLine(countClumps(new int[] { 1, 2, 2, 3, 4, 4 }));   // Output: 2
            Console.WriteLine(countClumps(new int[] { 1, 1, 2, 1, 1 }));      // Output: 2
            Console.WriteLine(countClumps(new int[] { 1, 1, 1, 1, 1 }));      // Output: 1

            // Accept input from user
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];

            // Collect array values from the user
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Call countClumps with user input and display the result
            int result = countClumps(numbers);
            Console.WriteLine("Number of clumps: " + result);
        }

        static int countClumps(int[] nums)
        {
            int clumpCount = 0;
            bool inClump = false;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    if (!inClump)
                    {
                        // Start of a new clump
                        clumpCount++;
                        inClump = true;
                    }
                }
                else
                {
                    // End of the current clump
                    inClump = false;
                }
            }

            return clumpCount;
        }
    }
}

