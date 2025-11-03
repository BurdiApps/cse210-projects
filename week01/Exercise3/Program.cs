using System;

class Program
{
    static void Main(string[] args)
    {
        // Guess my number game
        int myNumber = 21;
        int userGuess;
        do
        {
            Console.WriteLine("What's the magic number? ");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess < myNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if (userGuess > myNumber)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (userGuess != myNumber);
    }
}
