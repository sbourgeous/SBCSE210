using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayContent());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
            
            scripture.HideAWord(3);
            
            if (scripture.IsAllHidden())
            {
                Console.Clear();
                Console.WriteLine("All words are hidden! Well done.");
                break;
            }
        }
    }
}
