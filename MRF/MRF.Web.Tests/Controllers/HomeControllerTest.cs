using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MRF.Data.Services;
using MRF.Web.Controllers;
using MRF.Web.ViewModel;

namespace MRF.Web.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private readonly IFareCalculatorService _fareCalculatorService;

        [TestMethod]
        public void TestIndexView()
        {
            var controller = new HomeController(_fareCalculatorService);
            
            var result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ViewName);

        }
    }
}
