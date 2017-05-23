using System;

namespace MRF.Models
{
    public interface ITaxiRate
    {
        DateTime CreatedOn { get; set; }
        decimal DistanceUnitsPerMile { get; set; }
        decimal InitialEntryFee { get; set; }
        decimal NightTimeSurcharge { get; set; }
        decimal PeakHoursSurcharge { get; set; }
        State StateId { get; set; }
        decimal StateTaxSurcharge { get; set; }
        decimal TimedUnitsPerMinute { get; set; }
        decimal UnitReate { get; set; }
        DateTime UpdatedOn { get; set; }
    }
}