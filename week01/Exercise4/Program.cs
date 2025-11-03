using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store our numbers
        List<int> numbersList = new List<int>();
        
        // Tell the user what program does
        Console.WriteLine("Enter numbers one at a time. Enter 0 when finished.");

        // Get numbers from user until they enter 0
        int userNumber;
        do
        {
            Console.Write("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());

            // Only add the number if it's not 0
            if (userNumber != 0)
            {
                numbersList.Add(userNumber);
            }
        } while (userNumber != 0);

        // 1. Calculate the sum
        int sum = 0;
        foreach (int number in numbersList)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // 2. Calculate the average
        double average = (double)sum / numbersList.Count;
        Console.WriteLine($"The average is: {average}");

        // 3. Find the largest number
        int largest = numbersList[0];  // Start with first number
        foreach (int number in numbersList)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}