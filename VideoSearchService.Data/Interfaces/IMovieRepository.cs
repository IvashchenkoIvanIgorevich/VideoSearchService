using System.Collections.Generic;
using System.Threading.Tasks;
using VideoSearchService.Data.Models;

namespace VideoSearchService.Data.Interfaces
{
    public interface IMovieRepository : IRepository<Movie>
    {
        Task<IEnumerable<MovieGenre>> GetAllMoviesIncludeGenreAsync();
        Task<IEnumerable<Movie>> GetMovieByDescriptionAsync(string description);
    }
}
