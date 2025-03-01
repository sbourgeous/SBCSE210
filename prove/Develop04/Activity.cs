using System;
using System.Threading;

public class Activity
{
    protected string Name;
    protected string Description;
    protected int Duration;

    public virtual void ShowIntro()
    {
        Console.Clear();
        Console.WriteLine($"{Name}");
        Console.WriteLine(Description);
        Console.Write("Enter duration (seconds): ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public virtual void ShowEnding()
    {
        Console.WriteLine("Great job!");
        Console.WriteLine($"You completed {Name} for {Duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public virtual void Run()
    {
        Console.WriteLine("This activity does not have a specific implementation.");
    }
}