using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int magicGuess = -1;

        while (magicGuess != magicNumber)
        {
            Console.Write("What is your guess? ");
            magicGuess = int.Parse(Console.ReadLine());

            if (magicNumber > magicGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < magicGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }      
    }
}