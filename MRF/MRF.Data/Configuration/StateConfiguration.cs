using System.Data.Entity.ModelConfiguration;
using System.Threading;
using MRF.Models;

namespace MRF.Data.Configuration
{
    public class StateConfiguration : EntityTypeConfiguration<State>
    {
        public StateConfiguration()
        {
        }
    }
}