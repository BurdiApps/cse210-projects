using System;

class Program
{
    static void Main(string[] args)
    {
        // James Bonds style input practice
        Console.WriteLine("What is your first name? ");
        string firstName = Console.ReadLine();

        // note to self, add spaces in-between blocks of code for readability

        Console.WriteLine("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"My name is {lastName}, {firstName} {lastName}");
    }
}