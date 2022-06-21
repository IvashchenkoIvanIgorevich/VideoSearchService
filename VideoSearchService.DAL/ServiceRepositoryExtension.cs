using Microsoft.Extensions.DependencyInjection;
using VideoSearchService.Data.Interfaces;

namespace VideoSearchService.DAL
{
    public static class ServiceRepositoryExtension
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IMovieRepository, MovieRepository>();
            services.AddTransient<IActorRepository, ActorRepository>();
            services.AddTransient<IGenreRepository, GenreRepository>();
            services.AddTransient<IProfessionRepository, ProfessionRepository>();
            services.AddTransient<IRatingRepository, RatingRepository>();            
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            
            return services;
        }
    }
}
