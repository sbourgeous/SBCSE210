using System;

class Program
{
    static void DisplayMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Add New Job");
        Console.WriteLine("2. Display Resume");
        Console.WriteLine("3. Quit");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        bool keepRunning = true;
        Resume theResume = new Resume();

        while (keepRunning)
        {
            DisplayMenu();

            Console.Write("Enter Choice: ");
            string choice = Console.ReadLine();

            if(choice == "1")
            {
                // Add a new job
                Console.Write("What is the name of the company? ");
                string company = Console.ReadLine();

                Console.Write("What is the position? ");
                string position = Console.ReadLine();

                Job newJob = new Job();
                newJob._company = company;
                newJob._jobTitle = position;
                newJob._startYear = 2015;
                newJob._endYear = 2025;

                theResume._jobs.Add(newJob);
            }
            else if (choice == "2")
            {
                // Display the resume
                theResume.Display();
            }
            else if (choice == "3")
            {
                // Quit
                keepRunning = false;
                Console.WriteLine("Thank you, Goodbye.");
            }
            else
            {
                // Unexpected input
                Console.WriteLine("Not a valid input please try again.");
            }

        }

    /*
        Job job1 = new Job();
        job1._jobTitle = "Lanscaper";
        job1._company = "Yellowstone Bear World";
        job1._startYear = 2019;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Customer Service Representative";
        job2._company = "The Occasions Group";
        job2._startYear = 2020;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Samuel Bourgeous";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display(); 
    */
    }
}