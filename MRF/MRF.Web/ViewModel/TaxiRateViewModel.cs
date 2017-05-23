using System.ComponentModel.DataAnnotations;
using MRF.Models;
using MRF.Web.Infrastructure.Mapping;

namespace MRF.Web.ViewModel
{
    public class TaxiRateViewModel : IMapFrom<TaxiRate>
    {
        [Required]
        public decimal UnitReate { get; set; }

        [Required]
        public decimal InitialEntryFee { get; set; }

        [Required]
        public decimal StateTaxSurcharge { get; set; }

        [Required]
        public State StateId { get; set; }

        [Required]
        public decimal PeakHoursSurcharge { get; set; }

        [Required]
        public decimal NightTimeSurcharge { get; set; }

        [Required]
        public decimal TimedUnitsPerMinute { get; set; }

        [Required]
        public decimal DistanceUnitsPerMile { get; set; }
    }
}