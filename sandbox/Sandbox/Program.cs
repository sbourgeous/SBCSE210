using System;

class Program
{
    static void Main(string[] args)
    {
        // adjective = adj
        string adj = GetAdj();
        string noun = GetNoun();
        
        int number = Multiply(3, 4);

        Console.WriteLine($"I looked out the window and saw a {number} {adj} {noun}s.");
    }

    static int Multiply(int number1, int number2)
    {
        int product = number1 * number2;

        return product;
    }

    static string GetAdj()
    {
        List<string> words = new List<string>();
        words.Add("blue");
        words.Add("yellow");
        words.Add("big");
        words.Add("small");

        string adj = words[2];

        return adj;
    }

    static string GetNoun()
    {
        string noun = "bird";

        return noun;
    }
}