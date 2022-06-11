using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoSearchService.Service.Interfaces;

namespace VideoSearchService.ClientApp.Controllers
{
    public class MovieController : Controller
    {
        private ISearchService _searchService;

        public MovieController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpGet]
        public async Task<IActionResult> GetMovie(string searchInformation)
        {
            if (string.IsNullOrEmpty(searchInformation))
            {
                return BadRequest(new { errorText = "The search form doesn't fill" });
            }

            var movies = await _searchService.FetchFilmDataAsync(searchInformation);

            return View(movies);
        }
    }
}
