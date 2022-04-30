using System;
using System.Collections.Generic;
using System.Text;
using VideoSearchService.Data.Interfaces;

namespace VideoSearchService.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IMovieRepository Movies { get; }
        public IActorRepository Actors { get; }
        public IGenreRepository Genres { get; }
        public IProfessionRepository Professions { get; }
        public IRatingRepository Ratings { get; }

        public UnitOfWork(ApplicationDbContext context,
            IMovieRepository movieRepository, IActorRepository actorRepository,
            IGenreRepository genreRepository, IProfessionRepository professionRepository,
            IRatingRepository ratingRepository)
        {
            _context = context;

            Movies = movieRepository;
            Actors = actorRepository;
            Professions = professionRepository;
            Genres = genreRepository;
            Ratings = ratingRepository;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
