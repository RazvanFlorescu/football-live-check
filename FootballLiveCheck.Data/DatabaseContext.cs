using FootballLiveCheck.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FootballLiveCheck.Data
{
    public class DatabaseContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Team>()
                .HasKey(t => t.Id);
            builder.Entity<User>()
                .HasKey(t => t.Id);
        }

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Team> Teams { get; set; }

        public DbSet<User> Users { get; set; }
    }
}