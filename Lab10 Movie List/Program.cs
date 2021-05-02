using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab10_Movie_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 10 movies in this list.\n");

            bool repeat = true;

            while (repeat)
            {
                //Creates a new list of objects Movie.
                List<Movie> movies = new List<Movie>();

                Movie m1 = new Movie("Star Wars", "scifi");
                Movie m2 = new Movie("Star Trek", "scifi");
                Movie m3 = new Movie("Lilo and Stitch", "animated");
                Movie m4 = new Movie("Friday the 13th", "horror");
                Movie m5 = new Movie("Halloween", "horror");
                Movie m6 = new Movie("Casablanca", "drama");
                Movie m7 = new Movie("The Kings Speech", "drama");
                Movie m8 = new Movie("John Q", "drama");
                Movie m9 = new Movie("Toy Story", "animated");
                Movie m10 = new Movie("Spirited Away", "animated");
                movies.Add(m1);
                movies.Add(m2);
                movies.Add(m3);
                movies.Add(m4);
                movies.Add(m5);
                movies.Add(m6);
                movies.Add(m7);
                movies.Add(m8);
                movies.Add(m9);
                movies.Add(m10);

                

                Console.WriteLine("What type of movie are you interested in?");
                string genre = Console.ReadLine().ToLower();

                foreach (Movie film in movies)
                {
                    if (genre == film.Category)
                    {
                        //The selected category will return the movie titles.
                        film.Choice();

                    }
                }
                if (genre == "")
                {
                    Console.WriteLine("Please try again");
                    
                }

                //Loop back if the user selects y, or leaves the field blank.
                //All other selections will terminate the program.
                Console.WriteLine("Would you like to input another set of numbers? y/n");

                string answer = Console.ReadLine().ToLower();

                if (answer == "y")
                {
                    repeat = true;
                }
                else if (answer == "")
                {
                    repeat = true;
                }
                else
                {
                    Console.WriteLine("Goodbye.");
                    repeat = false;
                }
            }  
       
        }

    }
}

