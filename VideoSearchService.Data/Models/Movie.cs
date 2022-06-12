using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoSearchService.Data.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string? Title { get; set; }
        [MaxLength(300)]
        public string? Description { get; set; }
        [MaxLength(4)]
        public string Year { get; set; }        
        public short Duration { get; set; }
        public byte AgeLimit { get; set; }
        public IEnumerable<MovieActor> MovieActors { get; set; }
        public IEnumerable<Rating> Ratings { get; set; }
        public IEnumerable<MovieGenre> MovieGenres { get; set; }
        [NotMapped]
        public IEnumerable<Actor> Directors { get; set; }
        [NotMapped]
        public IEnumerable<Actor> Producers { get; set; }
    }
}
