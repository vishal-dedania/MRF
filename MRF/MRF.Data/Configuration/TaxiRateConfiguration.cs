using System.Data.Entity.ModelConfiguration;
using MRF.Models;

namespace MRF.Data.Configuration
{
    public class TaxiRateConfiguration : EntityTypeConfiguration<TaxiRate>
    {
        public TaxiRateConfiguration()
        {
            Property(p => p.CreatedOn)
                .IsRequired().HasColumnType("datetime");

            Property(p => p.UpdatedOn)
                .IsRequired().HasColumnType("datetime");
        }
    }
}