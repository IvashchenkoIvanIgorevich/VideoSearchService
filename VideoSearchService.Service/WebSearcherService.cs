using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VideoSearchService.Service.Interfaces;

namespace VideoSearchService.Service
{
    public class WebSearcherService : ISearchService
    {
        public Task<IEnumerable<ISource>> FetchFilmDataAsync(string searchInformation)
        {
            throw new NotImplementedException();
        }
    }
}
