using System.Data.Entity.ModelConfiguration;
using MRF.Models;

namespace MRF.Data.Configuration
{
    public class RideHistoryConfiguration : EntityTypeConfiguration<RideHistory>
    {
        public RideHistoryConfiguration()
        {
            ToTable("RideHistory");

            Property(p => p.CreatedOn)
                .IsRequired().HasColumnType("datetime");

            Property(p => p.UpdatedOn)
                .IsRequired().HasColumnType("datetime");
        }
    }
}
