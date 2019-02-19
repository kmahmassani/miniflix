using System;
using System.Linq;
using AutoMapper;
using RJP.EntityModels;
using RJP.Models.DTOs;

namespace RJP.BLL.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Movie, MovieForListDto>().ForMember(x => x.Genres, opt =>
            {
                opt.MapFrom(src => src.Genres.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList());
            });
            CreateMap<Movie, MovieDetailedDto>().ForMember(x => x.Genres,
                opt => { opt.MapFrom(src => src.Genres.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList()); });
        }
    }
}
