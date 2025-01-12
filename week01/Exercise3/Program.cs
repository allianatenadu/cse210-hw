using System;

class Program
{
    static void Main(string[] args)
    {
        // Game loop to allow replaying the game
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            // Generate a random magic number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;   // User's guess initialized to an invalid number
            int guessCount = 0;  // Count the number of guesses

            Console.WriteLine("Welcome to the Guess My Number Game!");

            // Loop until the user guesses the magic number
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();

                // Validate the input
                bool isValid = int.TryParse(input, out guess);

                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                    continue;
                }

                guessCount++;

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
                    Console.WriteLine($"You guessed it! It took you {guessCount} guesses.");
                }
            }

            // Ask the user if they want to play again
            Console.Write("\nWould you like to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}