using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VideoSearchService.Data
{
    public class Profession
    {
        public int Id { get; set; }
        [MaxLength(25)]
        public string Name { get; set; }
        public IEnumerable<Actor> Actors { get; set; }
    }
}
