using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using RJP.EntityModels;
using RJP.EntityModels.Interfaces;
using RJP.Models.DTOs;
using RJP.Models.Helpers;
using RJP.Models.Interfaces;

namespace RJP.BLL
{
    public class MovieManager : IMovieManager
    {
        private readonly IMovieRepository _repository;
        private readonly IMapper _mapper;

        public MovieManager(IMovieRepository repository, IMapper mapper)
        {
            this._repository = repository;
            _mapper = mapper;
        }

        public async Task<PagedList<MovieForListDto>> GetMovies(int page, int itemsPerPage, int maxItems, string genre, string orderBy)
        {
            PagedList<Movie> moviesFromRepo = await _repository.GetMovies(page, itemsPerPage, maxItems, genre, orderBy);
            var moviesDto = this._mapper.Map<List<MovieForListDto>>(moviesFromRepo);

            var moviesToReturn = new PagedList<MovieForListDto>(moviesDto, moviesFromRepo.TotalCount, moviesFromRepo.CurrentPage, moviesFromRepo.PageSize);

            return moviesToReturn;
        }        

        public async Task<MovieDetailedDto> GetMovie(int id)
        {
            var movieFromRepo = await _repository.GetMovie(id);
            var movieToReturn = _mapper.Map<MovieDetailedDto>(movieFromRepo);

            return movieToReturn;
        }
    }
}
