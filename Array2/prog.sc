using System;

namespace _1Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Initialize the array of prices
            double[] nos = { 19.99, 5.50, 10.00, 4.25, 99.99, 0.75 };

            // 2. Print out the dynamic total item count
            Console.WriteLine($"The array contains {nos.Length} items.");

            // 3. Loop through and print each element cleanly
            for (int i = 0; i < nos.Length; i++)
            {
                // ':F2' ensures prices print with 2 decimal places (e.g., 5.50 instead of 5.5)
                Console.WriteLine($"Price: {nos[i]:F2}");
            }
        }
    }
}
