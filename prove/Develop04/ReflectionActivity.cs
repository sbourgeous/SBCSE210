using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> Prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> Questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?"
    };

    public ReflectionActivity()
    {
        Name = "Reflection Activity";
        Description = "This activity will help you reflect on times when you showed strength and resilience.";
    }

    public override void Run()
    {
        ShowIntro();
        Random rand = new Random();
        Console.WriteLine(Prompts[rand.Next(Prompts.Count)]);
        ShowSpinner(3);

        for (int i = 0; i < Duration; i += 5)
        {
            Console.WriteLine(Questions[rand.Next(Questions.Count)]);
            ShowSpinner(5);
        }
        ShowEnding();
    }
}