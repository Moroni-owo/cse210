using System;

class Program
{
    static void Main()
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            // Generate a random number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int attempts = 0;

            Console.WriteLine("\nWelcome to Guess My Number!");
            // Uncomment the next line if you want to debug:
            // Console.WriteLine($"(Magic number is {magicNumber})");

            // Loop until guessed correctly
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {attempts} guesses!");
                }
            }

            // Ask if the user wants to play again
            Console.Write("\nDo you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}
