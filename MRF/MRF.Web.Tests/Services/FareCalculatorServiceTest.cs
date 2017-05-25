using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MRF.Data.Services;
using MRF.Models;
using MRF.Web.Tests.Fakes;

namespace MRF.Web.Tests.Services
{
    [TestClass]
    public class FareCalculatorServiceTest
    {
        private readonly FakeTaxiRateRepository _fakeTaxiRateRepository;

        public FareCalculatorServiceTest()
        {
            _fakeTaxiRateRepository = new FakeTaxiRateRepository();
        }

        [TestMethod]
        public void TestCalculate()
        {
            IFareCalculatorService service = new FareCalculatorService(_fakeTaxiRateRepository);

            var result = service.Calculate(new RideHistory
            {
                NumberOfMinutesIdleOrGoingAboveSixMph = 5,
                TotalMilesGoingBelowSixMph = 2,
                StartDateTime = DateTime.Parse("10/08/2010 05:30:00 pm")
            });
            Assert.AreEqual(result, 9.75m);
        }
    }
}
