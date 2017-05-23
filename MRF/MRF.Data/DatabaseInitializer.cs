using System.Data.Entity;
using System.Linq;
using MRF.Models;

namespace MRF.Data
{
    public class DatabaseInitializer :
        DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            if (!context.States.Any())
            {
                context.States.Add(new State
                {
                    StateId = "NJ",
                    StateName = "New Jersey"
                });

                context.States.Add(new State
                {
                    StateId = "NY",
                    StateName = "New York"
                });

                context.SaveChanges();
            }

            if (!context.TaxiRates.Any())
            {
                context.TaxiRates.Add(new TaxiRate
                {
                    StateId = context.States.Single(w => w.StateId.Equals("NJ")),
                    UnitReate = (decimal) 0.35,
                    DistanceUnitsPerMile = (decimal) 0.2,
                    TimedUnitsPerMinute = 1,
                    PeakHoursSurcharge = 1,
                    NightTimeSurcharge = (decimal) 0.5,
                    InitialEntryFee = 3,
                    StateTaxSurcharge = (decimal) 0.3,
                });

                context.TaxiRates.Add(new TaxiRate
                {
                    StateId = context.States.Single(w => w.StateId.Equals("NY")),
                    UnitReate = (decimal) 0.35,
                    DistanceUnitsPerMile = (decimal) 0.2,
                    TimedUnitsPerMinute = 1,
                    PeakHoursSurcharge = 1,
                    NightTimeSurcharge = (decimal) 0.5,
                    InitialEntryFee = 3,
                    StateTaxSurcharge = (decimal) 0.5,
                });

                context.SaveChanges();
            }
            base.Seed(context);
        }
    }
}