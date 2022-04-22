using Microsoft.EntityFrameworkCore; 

namespace Web_Server_Final.Models
{
    public class WebServerFinalContext : DbContext
    {
        public WebServerFinalContext(DbContextOptions<WebServerFinalContext> options)
            : base(options)
        { }

        public DbSet<Sport> Sports { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SportConfig());
            modelBuilder.ApplyConfiguration(new TeamConfig());
        }
    }
}
