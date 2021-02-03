using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public static class TempStorage
    {
        private static List<ApplicationResponse> movies = new List<ApplicationResponse>();

        public static IEnumerable<ApplicationResponse> Movies => movies;

        public static void AdddMovie(ApplicationResponse newMovie)
        {
            movies.Add(newMovie);
        }
    }
}
