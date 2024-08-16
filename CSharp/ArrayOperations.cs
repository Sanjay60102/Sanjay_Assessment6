using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class ArrayOperations
    {
        static void Main()
        {
            int[] numbers = { 5, 10, 15, 20, 25, 30 };
            int sum = numbers.Sum();
            double average = numbers.Average();
            int max = numbers.Max();
            int min = numbers.Min();

            // Display the results
            Console.WriteLine("Array elements: " + string.Join(", ", numbers));
            Console.WriteLine("Sum of all elements: " + sum);
            Console.WriteLine("Average of all elements: " + average);
            Console.WriteLine("Maximum value: " + max);
            Console.WriteLine("Minimum value: " + min);
        }
    }
}
