using Microsoft.EntityFrameworkCore;

namespace projeto_farmacia.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
