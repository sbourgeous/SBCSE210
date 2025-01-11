using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercent = Console.ReadLine();
        int percentNumber = int.Parse(gradePercent);

        string letter = "";

        if (percentNumber >= 93)
        {
            letter = "A";
        }
        else if (percentNumber >= 90)
        {
            letter = "A-";
        }
        else if (percentNumber >= 87)
        {
            letter = "B+";
        }
        else if (percentNumber >= 83)
        {
            letter = "B";
        }
        else if (percentNumber >= 80)
        {
            letter = "B-";
        }
        else if (percentNumber >= 77)
        {
            letter = "C+";
        }
        else if (percentNumber >= 73)
        {
            letter = "C";
        }
        else if (percentNumber >= 70)
        {
            letter = "C-";
        }
        else if (percentNumber >= 67)
        {
            letter = "D+";
        }
        else if (percentNumber >= 63)
        {
            letter = "D";
        }
        else if (percentNumber >= 60)
        {
            letter = "D-";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade: {letter}");

        if (percentNumber >= 70)
        {
            Console.WriteLine("You passed the class.");
        }
        else
        {
            Console.WriteLine("You failed the class: Retake is required.");
        }
    }
}