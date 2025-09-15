using System;

namespace LargestProductSeries;

class Program
{
    static void Main()
    {
       string digits = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843"
                          + "8586156078911294949545950173795833195285320880551112540698747158523863050715693290963295227443043557"
                          + "6689664895044524452316173185640309871112172238311362229893423380308135336276614282806444486645238749"
                          + "3035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776"
                          + "6572733300105336788122023542180975125454059475224352584907711670556013604839586446706324415722155397"
                          + "5369781797784617406495514929086256932197846862248283972241375657056057490261407972968652414535100474"
                          + "8216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586"
                          + "1786645835912456652947654568284891288314260769004224219022671055626321111109370544217506941658960408"
                          + "0719840385096245544436298123098787992724428490918884580156166097919133875499200524063689912560717606"
                          + "0588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";

            // Example 1: Find the highest product of a group of 4 consecutive digits
            Console.WriteLine("Highest product of consecutive digits: " + FindHighestProduct(digits, 4));

            // Example 2: Check if there's a group of 4 consecutive digits whose product equals 5832
            bool result = HasProductEqualTo(digits, 5832, 4);
            Console.WriteLine("Has group with product 5832: " + result);

            // Example 3: Check if any group of 4 consecutive digits has a product equal to the sum of any group of 4 consecutive digits
            bool comparisonResult = CompareProductAndSum(digits, 4);
            Console.WriteLine("Product equal to sum: " + comparisonResult);

    }
    // Method 1: Find group of x consecutive numbers with highest product
        static int FindHighestProduct(string digits, int x)
        {
            int maxProduct = 0;

            for (int i = 0; i <= digits.Length - x; i++)
            {
                string group = digits.Substring(i, x);
                int product = group.Select(digit => int.Parse(digit.ToString())).Aggregate(1, (a, b) => a * b);
                maxProduct = Math.Max(maxProduct, product);
            }

            return maxProduct;
        }

        // Method 2: Check if any group of x consecutive digits has a product equal to the argument int
        static bool HasProductEqualTo(string digits, int target, int x)
        {
            for (int i = 0; i <= digits.Length - x; i++)
            {
                string group = digits.Substring(i, x);
                int product = group.Select(digit => int.Parse(digit.ToString())).Aggregate(1, (a, b) => a * b);

                if (product == target)
                {
                    Console.WriteLine($"Found group: {group} with product {product}");
                    return true;
                }
            }

            return false;
        }

        // Method 3: Check if the product of any group of x consecutive numbers equals the sum of any group of x consecutive numbers
        static bool CompareProductAndSum(string digits, int x)
        {
            for (int i = 0; i <= digits.Length - x; i++)
            {
                // Get the product of the first group
                string group1 = digits.Substring(i, x);
                int product = group1.Select(digit => int.Parse(digit.ToString())).Aggregate(1, (a, b) => a * b);

                // Check if this product equals the sum of any group of x consecutive numbers
                for (int j = 0; j <= digits.Length - x; j++)
                {
                    string group2 = digits.Substring(j, x);
                    int sum = group2.Select(digit => int.Parse(digit.ToString())).Sum();

                    if (product == sum)
                    {
                        Console.WriteLine($"Product group: {group1} with product {product}, Sum group: {group2} with sum {sum}");
                        return true;
                    }
                }
            }

            return false;
        }
}

