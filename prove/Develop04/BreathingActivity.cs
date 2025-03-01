using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        Name = "Breathing Activity";
        Description = "This activity will help you relax by guiding you through slow breathing.";
    }

    public override void Run()
    {
        ShowIntro();
        for (int i = 0; i < Duration; i += 6)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
        }
        ShowEnding();
    }
}