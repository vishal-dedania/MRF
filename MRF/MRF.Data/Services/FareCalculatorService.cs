using MRF.Data.Repositories;

namespace MRF.Data.Services
{
    public class FareCalculatorService : IFareCalculatorService
    {
        private TaxiRateRepository _taxiRateRepository;

        public FareCalculatorService(TaxiRateRepository taxiRateRepository)
        {
            _taxiRateRepository = taxiRateRepository;
        }

        public decimal Calculate()
        {
            return 0;
        }
    }
}