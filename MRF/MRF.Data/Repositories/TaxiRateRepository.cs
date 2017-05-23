using System.Data.Entity;
using MRF.Models;

namespace MRF.Data.Repositories
{
    public class TaxiRateRepository : GenericRepository<TaxiRate>
    {
        public TaxiRateRepository(DataContext context) : base(context)
        {
        }
    }
}