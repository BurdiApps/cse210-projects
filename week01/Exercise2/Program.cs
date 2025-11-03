using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade %: ");
        int classGrade = int.Parse(Console.ReadLine());

        if (classGrade >= 97)
        {
            Console.WriteLine("You have an +A");
        }
        else if (classGrade >= 94)
        {
            Console.WriteLine("You have an A");
        }
        else if (classGrade >= 90)
        {
            Console.WriteLine("You have an A-");
        }
        else if (classGrade >= 87)
        {
            Console.WriteLine("You have a B+");
        }
        else if (classGrade >= 84)
        {
            Console.WriteLine("You have a B");
        }

        else if (classGrade >= 80)
        {
            Console.WriteLine("You have a B-");
        }
        else if (classGrade >= 77)
        {
            Console.WriteLine("You have a C+");
        }
        else if (classGrade >= 74)
        {
            Console.WriteLine("You have a C");
        }

        else if (classGrade >= 70)
        {
            Console.WriteLine("You have a C-");
        }

        else if (classGrade >= 67)
        {
            Console.WriteLine("You have a D+");
        }

        else if (classGrade >= 64)
        {
            Console.WriteLine("You have a D");
        }

        else if (classGrade >= 60)
        {
            Console.WriteLine("You have a D-");
        }

        else
        {
            Console.WriteLine("You have an F");
        }

    }

}