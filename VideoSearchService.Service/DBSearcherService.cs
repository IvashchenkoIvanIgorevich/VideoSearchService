using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoSearchService.Common.Interfaces;
using VideoSearchService.Common.Sources;
using VideoSearchService.Data.Interfaces;
using VideoSearchService.Service.Interfaces;

namespace VideoSearchService.Service
{
    public class DBSearcherService : ISearchService
    {
        private readonly IMovieRepository _movieRepository;

        public DBSearcherService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<IEnumerable<ISource>> FetchMoviesByDescriptionAsync(string description)
        {
            var movies = await _movieRepository.GetMovieByDescriptionAsync(description);

            return movies
                .Select(m => new DescriptionDBSource
                {
                    Name = m.Title,
                    Genre = m.MovieGenres?.Select(g => g.Genre?.Name).ToList(),
                    Description = m.Description
                });

            #region work version

            //var genres = await _genreRepository.GetAllAsync();

            //if (genres == null) return null;

            //return foundMoviesByDescription
            //    .Select(f => new DescriptionDBSource
            //    {
            //        Name = f?.Title,
            //        Genre = movieGenres?
            //            .Join(
            //                genres,
            //                mg => mg.GenreId,
            //                g => g.Id,
            //                (mg, g) => new { MovieId = mg.MovieId, GenreName = g.Name }
            //                )
            //            .Where(mgg => mgg.MovieId == f.Id)
            //            .Select(g => g.GenreName),
            //        Description = f?.Description
            //    });

            #endregion
        }
    }
}
