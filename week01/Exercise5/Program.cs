using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeUser();
        string userName = GetUserName();
        int favoriteNumber = GetFavoriteNumber();
        int square = CalculateSquare(favoriteNumber);

        Console.WriteLine($"{userName}, the square of your number is {square}");
    }

    static void WelcomeUser()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string GetUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int GetFavoriteNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int CalculateSquare(int number)
    {
        return number * number;
    }
}