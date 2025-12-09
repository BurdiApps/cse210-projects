using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold different activity types
        List<Activity> activities = new List<Activity>();

        // Create one of each type of activity
        Running running = new Running(new DateTime(2022, 11, 3), 30, 4.8);
        Cycling cycling = new Cycling(new DateTime(2022, 11, 4), 45, 25.0);
        Swimming swimming = new Swimming(new DateTime(2022, 11, 5), 30, 20);

        // Add activities to the list
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        // Iterate through the list and display summaries
        Console.WriteLine("Activity Summaries:\n");
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}