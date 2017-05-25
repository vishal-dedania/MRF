using System;
using System.ComponentModel.DataAnnotations;
using MRF.Models;
using MRF.Web.Infrastructure.Mapping;

namespace MRF.Web.ViewModel
{
    public class RideViewModel : IMapFrom<RideHistory>
    {
        [Required]
        public int? TotalMilesGoingBelowSixMph { get; set; }
        [Required]
        public int? NumberOfMinutesIdleOrGoingAboveSixMph { get; set; }
        [Required]
        public DateTime StartDateTime { get; set; } = DateTime.Now;
        [Required]
        public State StateId { get; set; }
        public decimal TotalPrice { get; set; }
    }
}