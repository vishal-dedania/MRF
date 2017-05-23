using System.Data.Entity;
using MRF.Models;

namespace MRF.Data.Repositories
{
    public class TaxiRateRepository : GenericRepository<TaxiRate>
    {
        public TaxiRateRepository(DbContext context) : base(context)
        {
        }
    }
}