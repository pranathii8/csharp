using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 101); // Random number between 1 and 100
        int userGuess = 0;
        int attempts = 0;

        Console.WriteLine("Guess the number (between 1 and 100):");

        while (userGuess != numberToGuess)
        {
            attempts++;
            Console.Write("Enter your guess: ");
            userGuess = Convert.ToInt32(Console.ReadLine());

            if (userGuess < numberToGuess)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (userGuess > numberToGuess)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
            }
        }
    }
}
