using System;

class Entry
{
    public string Author { get; set; }
    public string Date { get; set; }
    public string PromptQuestion { get; set; }
    public string Response { get; set; }

    public void GetFromUser()
    {
        // Asks for the writers/authors name
        Console.Write("Enter your name: ");
        Author = Console.ReadLine();
        // Gets random prompt for writers response
        Date = DateTime.Now.ToString("yyyy-MM-dd");
        PromptQuestion = new RandomPrompt().GetPrompt();
        Console.WriteLine(PromptQuestion);
        Console.Write("Your response: ");
        Response = Console.ReadLine();

        Console.WriteLine();
    }

    public void Display()
    {
        // How the contents (entries) will be displayed 
        Console.WriteLine($"{Date} - {Author}");
        Console.WriteLine($"{PromptQuestion}");
        Console.WriteLine($"{Response}");
    }

    public string GetCsvVersion()
    {
        return $"{Author},{Date},{PromptQuestion},{Response}";
    }
}