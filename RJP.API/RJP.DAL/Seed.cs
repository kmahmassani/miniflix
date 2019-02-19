using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using RJP.EntityModels;

namespace RJP.DAL
{
    public class Seed
    {
        private readonly DataContext _context;

        public Seed(DataContext context)
        {
            _context = context;
        }
        public void SeedData()
        {
            if (!_context.Movies.Any())
            {               
                var movieData = System.IO.File.ReadAllText("SeedData.json");	               
                var movies = JsonConvert.DeserializeObject<Movie[]>(movieData);
                
                foreach (var movie in movies)
                {                                        
                    _context.Movies.Add(movie);
                }

                _context.SaveChanges();
            }
        }
    }
}
