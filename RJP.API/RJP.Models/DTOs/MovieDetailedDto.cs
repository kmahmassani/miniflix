using System;
using System.Collections.Generic;
using System.Text;

namespace RJP.Models.DTOs
{
    public class MovieDetailedDto
    {
        public string PosterPath { get; set; }
        public bool Adult { get; set; }
        public string Overview { get; set; }
        public DateTime ReleaseDate { get; set; }        
        public int Id { get; set; }
        public string OriginalTitle { get; set; }
        public string OriginalLanguage { get; set; }
        public string Title { get; set; }
        public string BackdropPath { get; set; }
        public decimal Popularity { get; set; }
        public int VoteCount { get; set; }
        public bool Video { get; set; }
        public decimal VoteAverage { get; set; }   
        public List<string> Genres { get; set; }
    }
}
