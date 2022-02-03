using Microsoft.EntityFrameworkCore;

namespace VideoSearchService.UI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }
    }
}
