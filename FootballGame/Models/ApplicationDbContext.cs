using Microsoft.EntityFrameworkCore;

namespace FootballGame.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> user { get; set; }
    }
}
