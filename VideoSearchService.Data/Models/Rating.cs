using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VideoSearchService.Data.Models
{
    public class Rating
    {
        public int Id { get; set; }
        [MaxLength(15)]
        public string Name { get; set; }
        public double Mark { get; set; }
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }
    }
}
