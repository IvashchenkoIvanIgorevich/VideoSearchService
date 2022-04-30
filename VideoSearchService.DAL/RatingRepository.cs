using System;
using System.Collections.Generic;
using System.Text;
using VideoSearchService.Data.Interfaces;
using VideoSearchService.Data.Models;

namespace VideoSearchService.DAL
{
    public class RatingRepository : Repository<Rating>, IRatingRepository
    {
        public RatingRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
