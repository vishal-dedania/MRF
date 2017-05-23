using System;
using System.ComponentModel.DataAnnotations;

namespace MRF.Models
{
    public class TaxiRate : IAuditInfo
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public decimal UnitReate { get; set; }

        [Required]
        public decimal InitialEntryFee { get; set; }

        [Required]
        public decimal TaxSurcharge { get; set; }

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

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}