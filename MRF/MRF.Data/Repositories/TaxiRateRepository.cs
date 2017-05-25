using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using MRF.Models;

namespace MRF.Data.Repositories
{
    public class TaxiRateRepository : GenericRepository<TaxiRate>, ITaxiRateRepository
    {
        private readonly DataContext _context;
        public TaxiRateRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public TaxiRate GetTaxiRateByStateId(long stateId)
        {
            return _context.TaxiRates.FirstOrDefault(w => w.StateId.Id == stateId);
        }
    }
}