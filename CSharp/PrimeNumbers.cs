using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class PrimeNumbers
    {
        static void Main()
        {
            Console.Write("Enter the number of prime numbers to display: ");
            int N = int.Parse(Console.ReadLine());
            int count = 0; 
            int number = 2;
            while (count < N)
            {
                if (IsPrime(number))
                {
                    Console.Write(number + " ");
                    count++;
                }
                number++;
            }
            Console.WriteLine();
        }
        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true; // 2 is a prime number
            if (num % 2 == 0) return false; // Other even numbers are not primes

            // Check for factors from 3 up to the square root of num
            for (int i = 3; i * i <= num; i += 2)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
