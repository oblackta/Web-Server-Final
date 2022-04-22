using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Web_Server_Final.Models
{
    internal class SportConfig : IEntityTypeConfiguration<Sport>
    {
        public void Configure(EntityTypeBuilder<Sport> entity)
        {
            entity.HasData(
               new Sport { SportId = 1, SportName = "Basketball" },
               new Sport { SportId = 2, SportName = "Football" },
               new Sport { SportId = 3, SportName = "Soccer" },
               new Sport { SportId = 4, SportName = "Baseball" },
               new Sport { SportId = 5, SportName = "Rugby" },
               new Sport { SportId = 6, SportName = "Tennis" },
               new Sport { SportId = 7, SportName = "Lacrosse" }
            );
        }
    }
}
