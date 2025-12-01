using System;
using System.Threading;

// Creativity and Exceeding Requirements:
// 1. Enhanced breathing timing: 4 seconds breathe in, 6 seconds breathe out (matches realistic deep breathing)
// 2. Improved user experience: Clear screen between activity sections for better focus
// 3. Input validation: Handles invalid menu choices gracefully with error message
// 4. Better reflection flow: User presses enter when ready (not forced countdown) before questions begin

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            Activity activity = null;

            if (choice == "1")
            {
                activity = new BreathingActivity();
            }
            else if (choice == "2")
            {
                activity = new ReflectingActivity();
            }
            else if (choice == "3")
            {
                activity = new ListingActivity();
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Thread.Sleep(2000);
                continue;
            }

            if (activity != null)
            {
                activity.DisplayStartingMessage();
                activity.Run();
                activity.DisplayEndingMessage();
            }
        }
    }
}