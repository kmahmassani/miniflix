using System;
using System.Collections.Generic;
using System.Text;

namespace RJP.Models.DTOs
{
    public class MovieForListDto
    {
        public string PosterPath { get; set; }
        public bool Adult { get; set; }        
        public DateTime ReleaseDate { get; set; }        
        public int Id { get; set; }           
        public string Title { get; set; }
        public string BackdropPath { get; set; }
        public decimal Popularity { get; set; }
        public int VoteCount { get; set; }       
        public decimal VoteAverage { get; set; }
        public List<string> Genres { get; set; }
    }
}
