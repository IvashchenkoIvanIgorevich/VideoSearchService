using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VideoSearchService.Data.Interfaces;
using VideoSearchService.Service.Interfaces;

namespace VideoSearchService.Service
{
    public class DBSearcherService : ISearchService
    {
        public async Task<IEnumerable<ISource>> FetchFilmDataAsync(string searchInformation)
        {
            throw new NotImplementedException();
        }
    }
}
