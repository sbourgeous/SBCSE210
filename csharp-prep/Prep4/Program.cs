using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int enterNumber = -1;
        while(enterNumber != 0)
        {
            Console.Write("Please enter a number (0 to quit): ");

            string respone = Console.ReadLine();
            enterNumber = int.Parse(respone);

            if (enterNumber != 0)
            {
                numbers.Add(enterNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is {sum}.");

        float avg = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {avg}.");

        int max = numbers [0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The maximum is {max}.");
    }
}