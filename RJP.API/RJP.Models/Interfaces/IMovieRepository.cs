using System.Threading.Tasks;
using RJP.Models.Helpers;

namespace RJP.EntityModels.Interfaces
{
    public interface IMovieRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<PagedList<Movie>> GetMovies(int pageNumber = 1, int pageSize = 10, int maxItems = 1000, string genre = "", string orderBy = "");
        Task<Movie> GetMovie(int id);
    }
}
