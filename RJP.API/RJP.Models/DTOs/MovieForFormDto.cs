using System;
using System.ComponentModel.DataAnnotations;

namespace RJP.Models.DTOs
{
    public class MovieForFormDto
    {
        [Required]
        public string PosterPath { get; set; }

        public bool Adult { get; set; }

        [Required]
        [StringLength(int.MaxValue, MinimumLength = 10, ErrorMessage = "You must specify an over at least 10 characters long")]
        public string Overview { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }        
        public int Id { get; set; }

        public string OriginalTitle { get; set; }
        public string OriginalLanguage { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string BackdropPath { get; set; }

        public decimal Popularity { get; set; }
        public int VoteCount { get; set; }
        public bool Video { get; set; }
        public decimal VoteAverage { get; set; }        

        [Required]
        public string Genres { get; set; }
    }
}
