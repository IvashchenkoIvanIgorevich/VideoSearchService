using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VideoSearchService.Data
{
    public class Rating
    {
        public int Id { get; set; }
        [MaxLength(15)]
        public string Name { get; set; }
        public byte Mark { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
    }
}
