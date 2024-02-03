using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var doubles = MyLinq.RandomDoubles().Where(l => l > 0.5).Take(10);
            
            foreach (var x in doubles)
                {
                Console.WriteLine(x);
            }

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

            var query3 = from movie in movies
                         where movie.Year > 2000
                         orderby movie.Rating descending
                         select movie;

            var enumerator = query3.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Title);
            }
        }
    }
}

