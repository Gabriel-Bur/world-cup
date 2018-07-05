using System.Data.Entity;
using WorldCup.Data.EntityConfig;
using WorldCup.Domain.Entities;

namespace WorldCup.Data.Context
{
    public class WorldCupContext:DbContext
    {

        public WorldCupContext() : base("DefaultConnection")
        { 
        }

        DbSet<Match> matches { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MatchConfig());
        }

    }
}
