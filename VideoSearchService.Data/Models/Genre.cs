using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VideoSearchService.Data.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
    }
}
