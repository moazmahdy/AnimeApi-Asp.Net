using Microsoft.EntityFrameworkCore;

namespace AnimeApi.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Gener> Geners { get; set; }
        public DbSet<Anime> Animes { get; set; }
    }
}
