using MRF.Data.Repositories;
using MRF.Models;

namespace MRF.Data.Services
{
    public class FareCalculatorService : IFareCalculatorService
    {
        private TaxiRateRepository _taxiRateRepository;

        public FareCalculatorService(TaxiRateRepository taxiRateRepository)
        {
            _taxiRateRepository = taxiRateRepository;
        }

        public decimal Calculate(TaxiRate taxiRate)
        {
            return 0;
        }
    }
}