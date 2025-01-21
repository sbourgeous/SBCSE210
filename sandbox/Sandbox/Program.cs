using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Movie favoriteMovie = new Movie();
        favoriteMovie._title = "Star Wars";
        favoriteMovie._year = 1977;
        favoriteMovie._runtime = 150;
        favoriteMovie._rating = "PG";

        Movie otherMovie =  new Movie();
        otherMovie._title = "Avatar";
        otherMovie._year = 2009;
        otherMovie._runtime = 162;
        otherMovie._rating = "PG-13";

        // Linked with Member Function:
        favoriteMovie.Display();

        // Linked with Member Variables:
        DisplayMovie(favoriteMovie);
        DisplayMovie(otherMovie);
    }

    static void DisplayMovie(Movie aMovie)
    {
        Console.WriteLine($"{aMovie._title} - {aMovie._year}");
    }

}