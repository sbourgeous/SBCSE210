using System;
using System.Collections.Generic;

class ActivityManager
{
    private List<Activity> activities = new List<Activity>
    {
        new BreathingActivity(),
        new ReflectionActivity(),
        new ListingActivity()
    };

    public void ShowMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            if (choice == "4") break;
            if (int.TryParse(choice, out int index) && index >= 1 && index <= activities.Count)
            {
                activities[index - 1].Run();
            }
        }
    }
}