using VideoSearchService.Data.Interfaces;
using VideoSearchService.Data.Models;

namespace VideoSearchService.DAL
{
    public class ProfessionRepository : Repository<Profession>, IProfessionRepository
    {
        public ProfessionRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
