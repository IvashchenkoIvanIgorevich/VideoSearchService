using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VideoSearchService.Common.Interfaces;
using VideoSearchService.Service.Interfaces;

namespace VideoSearchService.Service
{
    public class WebSearcherService : ISearchService
    {
        public Task<IEnumerable<ISource>> FetchMoviesByDescriptionAsync(string description)
        {
            throw new NotImplementedException();
        }
    }
}
