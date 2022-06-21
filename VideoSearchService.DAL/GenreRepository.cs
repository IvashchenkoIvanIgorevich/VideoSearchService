using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoSearchService.Data.Interfaces;
using VideoSearchService.Data.Models;

namespace VideoSearchService.DAL
{
    public class GenreRepository : Repository<Genre>, IGenreRepository
    {
        public GenreRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<string>> GetGenresByMovieId(int movieId) => await Entities
                .Include(g => g.MovieGenres)
                .SelectMany(mg => mg.MovieGenres)
                .Where(mg => mg.MovieId == movieId)
                .Select(g => g.Genre.Name)
                .ToListAsync();
    }
}
