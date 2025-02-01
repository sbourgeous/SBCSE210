using System;
using System.Collections.Generic;

class RandomPrompt
{   
    // The prompt generator
    public static Random rand = new Random();
    public List<string> _prompts = new List<string>
    {
        // List of prompts
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is a goal you have for this week?",
        "What is something you would like your family to know?",
    };

    public string GetPrompt()
    {
        return _prompts[rand.Next(_prompts.Count)];
    }
}