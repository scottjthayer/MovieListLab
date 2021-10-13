using System;
using System.Collections.Generic;
using System.Linq;
using Validator;
namespace Movie_List_Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Movie> movieList = new List<Movie>
            {
            new Movie ("The Truman Show", "drama"),
            new Movie ("Children of Men", "scifi"),
            new Movie ("Hot Rod", "comedy"),
            new Movie ("Interstellar", "scifi"),
            new Movie ("The Dark Night Rises", "drama"),
            new Movie ("Drive", "drama"),
            new Movie ("Palm Springs", "comedy"),
            new Movie ("Rounders", "drama"),
            new Movie ("Arrival", "scifi"),
            new Movie ("Annihilation", "horror"),
            };
            List<string> Categories = new List<string>
            {
                "Drama",
                "Scifi",
                "Comedy",
                "Horror",
            };

            string input = "";
            bool run = true;

            Console.WriteLine("Welcome to the Movie List App!");

            while (run == true)
            {
                while (true)
                {
                    
                    Console.WriteLine("Please enter a category from the following list to see which films are available.");
                    foreach (string i in Categories)
                    {
                        Console.WriteLine(i);
                    }
                    input = Console.ReadLine().ToLower().Trim();

                    if (input == "")
                    {
                        Console.WriteLine("I am sorry you didn't enter anything. Try again.");
                        continue;
                    }
                    else if (input == "drama" || input == "scifi" || input == "comedy" || input == "horror")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That was an invalid input. Try again");
                        continue;
                    }
                }
                Console.WriteLine($"\nHere is the list of {input} movies:");

                foreach (Movie i in movieList)
                {
                    if (i.GetCategory() == input)
                    {
                        Console.WriteLine(i.GetTitle());
                    }
                }


                run = Validator.Validator.getContinue();
            }
            Console.WriteLine("\nThank you for using the Movie List App.");

        }
    }
}
