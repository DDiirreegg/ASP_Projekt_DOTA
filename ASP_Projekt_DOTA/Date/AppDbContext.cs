using Microsoft.EntityFrameworkCore;

namespace ASP_Projekt_DOTA.Date
{
    public class AppDbContext:DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }
    }
}
