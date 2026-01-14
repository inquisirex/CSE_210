using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        Console.WriteLine("Welcome to the number guessing name.");
        int testGuess = randomGenerator.Next(1, 100);
        int lastGuess = -1;

        while (testGuess != lastGuess)
        {
            Console.WriteLine("Please input your guess.");
            string lastGuessSTR = Console.ReadLine();
            lastGuess = int.Parse(lastGuessSTR);

            if (lastGuess > testGuess)
            {
                Console.WriteLine("Guess too high!");
            }
            else if (lastGuess < testGuess)
            {
                Console.WriteLine("Guess was too low!");
            }
        }
        Console.WriteLine("You have guessed the number!");

    }
}