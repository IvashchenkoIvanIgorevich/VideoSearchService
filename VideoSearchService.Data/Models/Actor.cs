using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VideoSearchService.Data.Models
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
        public IEnumerable<ActorProfession> ActorProfessions { get; set; }
        public IEnumerable<MovieActor> MovieActors { get; set; }
    }
}
