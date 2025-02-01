using System;

class Program
{
    static void DisplayMenu()
    {
        Console.WriteLine("Journal Menu:");
        Console.WriteLine("1. Write a new journal entry");
        Console.WriteLine("2. Display current journal entry");
        Console.WriteLine("3. Save current journal entry to a file");
        Console.WriteLine("4. Load a journal entry from a file");
        Console.WriteLine("5. Exit");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        bool keepRunning = true;
        Journal myJournal = new Journal();

        while (keepRunning)
        {
            DisplayMenu();

            Console.Write("Enter Choice (numeric value): ");
            string choice = Console.ReadLine();

            if(choice == "1")
            {
                // Write a new entry
                Entry newEntry = new Entry();
                newEntry.GetFromUser();
                myJournal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                // Display the journal entires
                myJournal.Display();
            }
            else if (choice =="3")
            {
                // Save a journal entry
                Console.Write("Enter filename to save journal: ");
                string saveFile = Console.ReadLine();
                myJournal.Save(saveFile);
            }
            else if (choice =="4")
            {
                // Load a journal entry
                Console.Write("Enter filename to load journal: ");
                string loadFile = Console.ReadLine();
                myJournal.LoadFromFile(loadFile);
            }
            else if (choice == "5")
            {
                // Quit
                keepRunning = false;
                Console.WriteLine("Thank you, Goodbye.");
            }
            else
            {
                // Unexpected input
                Console.WriteLine("Not a valid input please try again.");
                Console.WriteLine();
            }

        }

    }
}