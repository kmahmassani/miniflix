using System.Collections.Generic;
using System.Threading.Tasks;
using RJP.Models.DTOs;
using RJP.Models.Helpers;

namespace RJP.Models.Interfaces
{
    public interface IMovieManager
    {
        Task<PagedList<MovieForListDto>> GetMovies(int page, int itemsPerPage, int maxItems, string genre, string orderBy);
        Task<MovieDetailedDto> GetMovie(int id);
    }
}
