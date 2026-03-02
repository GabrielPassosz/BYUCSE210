using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        string playAgain;

        do
        {
            int magicNumber = randomGenerator.Next(1, 101); // 1..100
            int guess = -1;
            int guessCount = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();
                guess = int.Parse(input);
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
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine($"Number of guesses: {guessCount}");

            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine().Trim().ToLower();

        } while (playAgain == "yes");
    }
}