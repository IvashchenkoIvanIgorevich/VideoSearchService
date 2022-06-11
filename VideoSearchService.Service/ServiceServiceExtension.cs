using Microsoft.Extensions.DependencyInjection;
using VideoSearchService.Service.Interfaces;

namespace VideoSearchService.Service
{
    public static class ServiceServiceExtension
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddTransient<ISearchService, DBSearcherService>();

            return services;
        }
    }
}
