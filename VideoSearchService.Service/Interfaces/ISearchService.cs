using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VideoSearchService.Service.Interfaces
{
    public interface ISearchService
    {
        Task<IEnumerable<ISource>> FetchFilmDataAsync(string searchInformation);
    }
}
