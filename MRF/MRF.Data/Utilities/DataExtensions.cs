using System;

namespace MRF.Data.Utilities
{
    public static class DataExtensions
    {
        private static readonly TimeSpan StartOfNightHours = new TimeSpan(20, 0, 0);
        private static readonly TimeSpan EndOfNightHours = new TimeSpan(6, 0, 0);
        private static readonly TimeSpan StartOfPeakHours = new TimeSpan(16, 0, 0);
        private static readonly TimeSpan EndOfPeakHours = new TimeSpan(20, 0, 0);

        private static bool IsWeekend(this DateTime value)
        {
            return (value.DayOfWeek == DayOfWeek.Sunday || value.DayOfWeek == DayOfWeek.Saturday);
        }

        public static bool IsPeakHours(this DateTime value)
        {
            return (!value.IsWeekend() && value.TimeOfDay >= StartOfPeakHours && value.TimeOfDay < EndOfPeakHours);
        }

        public static bool IsNightHours(this DateTime value)
        {
            if (StartOfNightHours < EndOfNightHours)
            {
                return (value.TimeOfDay >= StartOfNightHours && value.TimeOfDay < EndOfNightHours);
            }
            if (value.TimeOfDay < EndOfNightHours || value.TimeOfDay >= StartOfNightHours)
            {
                return true;
            }
            return false;
        }
    }
}