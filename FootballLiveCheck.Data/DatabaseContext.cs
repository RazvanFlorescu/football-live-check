using FootballLiveCheck.Data.Mappings;
using FootballLiveCheck.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FootballLiveCheck.Data
{
    public class DatabaseContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            new TeamMapping(builder);
            new LeagueMapping(builder);
            new UserMapping(builder);
            new ArenaMappping(builder);
            new RegionMapping(builder);

        }
        public DatabaseContext(DbContextOptions options) : base(options)
        {
            Database.Migrate();
            Database.SetCommandTimeout(9000);
        }

        public DbSet<Team> Teams{ get; set; }

        public DbSet<League> Leagues { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Match> Matches { get; set; }
    }
}