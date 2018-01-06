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
            TeamMapping teamMapping = new TeamMapping(builder);
            LeagueMapping leagueMapping = new LeagueMapping(builder);
            UserMapping userMapping = new UserMapping(builder);
        }
        public DatabaseContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Team> Teams{ get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<League> Users { get; set; }
    }
}