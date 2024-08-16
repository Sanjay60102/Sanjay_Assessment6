using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class GuessNumber
    {
        static void Main()
        {
            int minNumber = 1;
            int maxNumber = 100;
            int maxAttempts = 5;
            Random random = new Random();
            int targetNumber = random.Next(minNumber, maxNumber + 1);

            Console.WriteLine($"Guess the number between {minNumber} and {maxNumber}. You have {maxAttempts} attempts.");
            //loop for number of attempts
            for (int attempt = 1; attempt <= maxAttempts; attempt++)
            {
                Console.Write($"Attempt {attempt}: ");
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int guess))
                {
                    if (guess == targetNumber)
                    {
                        Console.WriteLine("Congratulations! You guessed the number correctly.");
                        return;
                    }
                    else if (guess < targetNumber)
                    {
                        Console.WriteLine("Too low. Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Too high. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
            Console.WriteLine($"Sorry, you've used all {maxAttempts} attempts. The correct number was {targetNumber}.");
        }
    }
}
