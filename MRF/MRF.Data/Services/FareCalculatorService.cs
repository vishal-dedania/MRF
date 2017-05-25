using MRF.Data.Repositories;
using MRF.Data.Utilities;
using MRF.Models;

namespace MRF.Data.Services
{
    public class FareCalculatorService : IFareCalculatorService
    {
        private readonly TaxiRateRepository _taxiRateRepository;

        public FareCalculatorService(TaxiRateRepository taxiRateRepository)
        {
            _taxiRateRepository = taxiRateRepository;
        }

        public decimal Calculate(RideHistory ride)
        {
            decimal totalPrice = 0;
            var stateId = 2; // NY TODO: Get value from UI
            var taxiRate = _taxiRateRepository.GetTaxiRateByStateId(stateId);

            var timedUnitVal = ride.NumberOfMinutesIdleOrGoingAboveSixMph / taxiRate.TimedUnitsPerMinute;
            var distanceUnitVal = ride.TotalMilesGoingBelowSixMph / taxiRate.DistanceUnitsPerMile;

            totalPrice += taxiRate.InitialEntryFee;
            totalPrice += (timedUnitVal + distanceUnitVal) * taxiRate.UnitReate;
            totalPrice += taxiRate.StateTaxSurcharge;

            if (ride.StartDateTime.IsPeakHours())
            {
                totalPrice += taxiRate.PeakHoursSurcharge;
            }

            if (ride.StartDateTime.IsNightHours())
            {
                totalPrice += taxiRate.NightTimeSurcharge;
            }

            return totalPrice;
        }
    }
}