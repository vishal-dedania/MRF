using MRF.Models;

namespace MRF.Data.Repositories
{
    public class RideHistoryRepository : GenericRepository<RideHistory>
    {
        public RideHistoryRepository(DataContext context) : base(context)
        {
        }
    }
}
