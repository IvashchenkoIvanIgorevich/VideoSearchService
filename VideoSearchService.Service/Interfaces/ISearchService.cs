using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VideoSearchService.Common.Interfaces;

namespace VideoSearchService.Service.Interfaces
{
    public interface ISearchService
    {
        Task<IEnumerable<ISource>> FetchMoviesByDescriptionAsync(string description);
    }
}
