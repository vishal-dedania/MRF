using System;
using MRF.Models;

namespace MRF.Web.ViewModel
{
    public class RideViewModel
    {
        public int? TotalMilesGoingBelowSixMph { get; set; }
        public int? NumberOfMinutesIdleOrGoingAboveSixMph { get; set; }
        public DateTime StartDateTime { get; set; } = DateTime.Now;
        public State States { get; set; }
    }
}