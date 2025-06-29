using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMoviesApp
{
    internal class MovieManager
    {
        Movie[] movies = new Movie[5];
        static int count = 0;

        public void addMovie()
        {
            if (count > movies.Length - 1)
            {
                Console.WriteLine("array is full");
            }
            else
            {
                Console.WriteLine("Enter movie id");
                int movieId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter movie Name");
                string movieName = (Console.ReadLine());
                Console.WriteLine("Enter movie Genre");
                string movieGenre = (Console.ReadLine());
                Console.WriteLine("Enter movie Release Date");
                string movieYear = (Console.ReadLine());


                movies[count++] = new Movie(movieId,movieName,movieGenre,movieYear);
            }

        }

        public void displayMovies()
        {
            if(count == 0)
            {
                Console.WriteLine("no movies found");
            }
            for (int i = 0; i < count; i++)
            {

                Console.WriteLine(movies[i].ToString());
            }
        }
        public void ClearMovies()
        {
            movies = new Movie[5];
            count = 0;
            Console.WriteLine("All movies cleared.");
        }

    }
}
