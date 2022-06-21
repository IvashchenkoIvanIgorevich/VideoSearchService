using System.Collections.Generic;
using System.Threading.Tasks;
using VideoSearchService.Data.Models;

namespace VideoSearchService.Data.Interfaces
{
    public interface IGenreRepository : IRepository<Genre>
    {
        Task<IEnumerable<string>> GetGenresByMovieId(int movieId);
    }
}
