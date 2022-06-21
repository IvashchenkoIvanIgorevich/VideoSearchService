using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoSearchService.Data.Interfaces;
using VideoSearchService.Data.Models;

namespace VideoSearchService.DAL
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        public MovieRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Movie>> GetMovieByDescriptionAsync(string description) => await Entities
            .Where(m => m.Description.Contains(description))
            .Include(m => m.MovieGenres)
            .ThenInclude(g => g.Genre)
            .ToListAsync();

        public async Task<IEnumerable<MovieGenre>> GetAllMoviesIncludeGenreAsync() => await Entities
            .Include(m => m.MovieGenres)
                .ThenInclude(g => g.Genre)
            .SelectMany(mg => mg.MovieGenres)
            .ToListAsync();
    }
}
