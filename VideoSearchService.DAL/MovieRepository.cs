using VideoSearchService.Data.Interfaces;
using VideoSearchService.Data.Models;

namespace VideoSearchService.DAL
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        public MovieRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
