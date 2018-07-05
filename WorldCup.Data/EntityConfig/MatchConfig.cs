using System.Data.Entity.ModelConfiguration;
using WorldCup.Domain.Entities;

namespace WorldCup.Data.EntityConfig
{
    public class MatchConfig: EntityTypeConfiguration<Match>
    {
        public MatchConfig()
        {
            //ID
            HasKey(m => m.Id);

            //Team1
            Property(m => m.Team1)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);



            //Team2
            Property(m => m.Team2)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);


        }

    }
}
