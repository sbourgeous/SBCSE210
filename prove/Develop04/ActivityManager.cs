using System;
using System.Collections.Generic;
using System.Threading;

class ActivityManager
{
    private BreathingActivity breather = new BreathingActivity();
    private ReflectionActivity reflecter = new ReflectionActivity();
    private ListingActivity lister = new ListingActivity();

    public void ShowMenu()
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                breather.Run();
            }
            else if (choice == "2")
            {
                reflecter.Run();
            }
            else if (choice == "3")
            {
                lister.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Not a valid option please try again...");
                Thread.Sleep(1500);
            }
        }
    }
}