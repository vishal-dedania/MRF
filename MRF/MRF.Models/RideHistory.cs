using System;
using System.ComponentModel.DataAnnotations;

namespace MRF.Models
{
    public class RideHistory : IAuditInfo
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public int TotalMilesGoingBelowSixMph { get; set; }

        [Required]
        public int NumberOfMinutesIdleOrGoingAboveSixMph { get; set; }

        [Required]
        public DateTime StartDateTime { get; set; }

        [Required]
        public State StateId { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}