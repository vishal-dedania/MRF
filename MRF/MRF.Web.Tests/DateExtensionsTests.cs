using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MRF.Data.Utilities;

namespace MRF.Web.Tests
{
    [TestClass]
    public class DateExtensionsTests
    {
        [TestMethod()]
        public void LateNightIsNightTest()
        {
            var dateTime = DateTime.Parse("10/08/2017 09:30 pm");
            Assert.IsTrue(dateTime.IsNightHours());
        }
        [TestMethod()]
        public void EarlyMorningIsNightTest()
        {
            var dateTime = DateTime.Parse("10/08/2017 04:30 am");
            Assert.IsTrue(dateTime.IsNightHours());
        }
        [TestMethod()]
        public void DayIsNightTest()
        {
            var dateTime = DateTime.Parse("10/08/2017 11:00 pm");
            Assert.IsTrue(dateTime.IsNightHours());
        }
    }
}
