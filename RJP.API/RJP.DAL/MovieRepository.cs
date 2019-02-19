using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RJP.EntityModels;
using RJP.EntityModels.Interfaces;
using RJP.Models.Helpers;

namespace RJP.DAL
{
    public class MovieRepository : IMovieRepository
    {
        private readonly DataContext _context;
        public MovieRepository(DataContext context)
        {
            this._context = context;

        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<PagedList<Movie>> GetMovies(int pageNumber = 0, int pageSize = 10, int maxItems = 1000, string genre = "", string orderBy = "")
        {
            var movies = _context.Movies.AsQueryable();

            if (!string.IsNullOrEmpty(genre))
            {
                movies = movies.Where(x => x.Genres.Contains(genre,StringComparison.CurrentCultureIgnoreCase));
            }

            if (!string.IsNullOrEmpty(orderBy))
            {
                switch (orderBy)
                {
                    case "hot": movies = movies.OrderByDescending(x => x.Popularity);
                        break;
                    case "new": movies = movies.OrderByDescending(x => x.ReleaseDate);
                        break;
                    case "rating": movies = movies.OrderByDescending(x => x.VoteAverage);
                        break;
                }
            }


            return await PagedList<Movie>.CreateAsync(movies.Take(maxItems), pageNumber,pageSize);
        }

        public async Task<Movie> GetMovie(int id)
        {
            return await _context.Movies.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
