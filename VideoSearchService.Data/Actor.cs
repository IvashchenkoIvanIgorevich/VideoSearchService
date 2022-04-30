using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VideoSearchService.Data
{
    public class Actor
    {
        public int Id { get; set; }
        [MaxLength(15)]
        public string FirstName { get; set; }
        [MaxLength(15)]
        public string LastName { get; set; }
        [MaxLength(300)]
        public string? Description { get; set; }
        public IEnumerable<Profession> Professions { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
    }
}
