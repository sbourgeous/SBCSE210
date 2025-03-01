using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> Prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        Name = "Listing Activity";
        Description = "This activity will help you reflect on the good things in your life by listing them.";
    }

    public override void Run()
    {
        ShowIntro();
        Random rand = new Random();
        Console.WriteLine(Prompts[rand.Next(Prompts.Count)]);
        ShowCountDown(5);

        List<string> responses = new List<string>();
        Console.WriteLine("Start listing items:");
        int endTime = Environment.TickCount + (Duration * 1000);
        while (Environment.TickCount < endTime)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                responses.Add(input);
            }
        }
        Console.WriteLine($"You listed {responses.Count} items.");
        ShowEnding();
    }
}