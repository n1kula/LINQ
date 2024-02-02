using System;
using System.Collections.Generic;


namespace BasicQueries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var movies = new List<Film>
            {
                new Film {Title = "Bad Boys", Type = "Comedy", Rating = 8.2, Year = 2005},
                new Film {Title = "Gladiator", Type = "Drama", Rating = 7.2, Year = 2010},
                new Film {Title = "Kiler", Type = "Comedy", Rating = 5.2, Year = 1999},
            };

            var query = movies.MyFilter(f => f.Year > 2005);

            foreach (var film in query)
            {
                Console.WriteLine(film.Title);
            }

            var query2 = movies.MyFilterLikeWhere(f => f.Year > 2005);

            foreach (var film in query)
            {
                Console.WriteLine(film.Title);
            }
        }
    }
}
