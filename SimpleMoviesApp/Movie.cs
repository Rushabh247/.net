using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMoviesApp
{
    internal class Movie
    {
        public int movieId;
        public string movieName;
        public string movieGenre;
        public string movieYear;

        public Movie(int movieId, string movieName, string movieGenre, string movieYear)
        {
            this.movieId = movieId;
            this.movieName = movieName;
            this.movieGenre = movieGenre;
            this.movieYear = movieYear;
        }
        public override string ToString()
        {
            return ($"Movie Id : {movieId} , Movie Name : {movieName} , Movie Genre : {movieGenre} , Movie Release Date : {movieYear}");
        }
    }
}
