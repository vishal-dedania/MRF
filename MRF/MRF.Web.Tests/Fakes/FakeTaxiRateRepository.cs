using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Components.DictionaryAdapter;
using MRF.Data.Repositories;
using MRF.Models;

namespace MRF.Web.Tests.Fakes
{
    public class FakeTaxiRateRepository : ITaxiRateRepository
    {
        private readonly IList<TaxiRate> _taxiRates;

        public FakeTaxiRateRepository()
        {
            _taxiRates = new List<TaxiRate>();
            _taxiRates.Add(new TaxiRate
            {
                StateId = new State {Id = 1, StateId = "NJ", StateName = "New Jersey"},
                UnitReate = (decimal)0.35,
                DistanceUnitsPerMile = (decimal)0.2,
                TimedUnitsPerMinute = 1,
                PeakHoursSurcharge = 1,
                NightTimeSurcharge = (decimal)0.5,
                InitialEntryFee = 3,
                StateTaxSurcharge = (decimal)0.3
            });

            _taxiRates.Add(new TaxiRate
            {
                StateId = new State { Id = 2, StateId = "NY", StateName = "New York" },
                UnitReate = (decimal)0.35,
                DistanceUnitsPerMile = (decimal)0.2,
                TimedUnitsPerMinute = 1,
                PeakHoursSurcharge = 1,
                NightTimeSurcharge = (decimal)0.5,
                InitialEntryFee = 3,
                StateTaxSurcharge = (decimal)0.5
            });
        }

        public TaxiRate GetTaxiRateByStateId(long stateId)
        {
            return _taxiRates.Single(e => e.StateId.Id == stateId);
        }
    }
}
