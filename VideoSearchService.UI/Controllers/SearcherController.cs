using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoSearchService.Service.Interfaces;

namespace VideoSearchService.UI.Controllers
{
    [Route("search")]
    public class SearcherController
    {
        private readonly ISearchService _searchService;

        public SearcherController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpGet]
        public async Task<IEnumerable<ISource>> Get(string searchInformation)
        {
            return await _searchService.FetchFilmDataAsync(searchInformation);
        }
    }
}
