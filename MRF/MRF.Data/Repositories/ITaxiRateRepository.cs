using MRF.Models;

namespace MRF.Data.Repositories
{
    public interface ITaxiRateRepository
    {
        TaxiRate GetTaxiRateByStateId(long stateId);
    }
}