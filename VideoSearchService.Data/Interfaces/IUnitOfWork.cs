using System;
using System.Collections.Generic;
using System.Text;

namespace VideoSearchService.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IMovieRepository Movies { get; }
        IActorRepository Actors { get; }
        IGenreRepository Genres { get; }
        IProfessionRepository Professions { get; }
        IRatingRepository Ratings { get; }
        int Commit();
    }
}
