using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Web_Server_Final.Models
{
    internal class TeamConfig : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> entity)
        {
            entity.HasData(
               new Team { TeamId = 1, TeamName = "Bengals", City = "Cincinnati", SportId = 2 },
               new Team { TeamId = 2, TeamName = "Reds", City = "Cincinnati", SportId = 4 },
               new Team { TeamId = 3, TeamName = "Heat", City = "Miami", SportId = 1 },
               new Team { TeamId = 4, TeamName = "Kings", City = "Sacremento", SportId = 1 },
               new Team { TeamId = 5, TeamName = "Braves", City = "Atlanta", SportId = 4 },
               new Team { TeamId = 6, TeamName = "Colts", City = "Indiana", SportId = 2 },
               new Team { TeamId = 7, TeamName = "FC", City = "Cincinnati", SportId = 3 }
            );
        }
    }
}
