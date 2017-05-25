using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using MRF.Data.Services;
using MRF.Models;
using MRF.Web.ViewModel;

namespace MRF.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IFareCalculatorService _fareCalculatorService;

        public HomeController(IFareCalculatorService fareCalculatorService)
        {
            _fareCalculatorService = fareCalculatorService;
        }

        public ActionResult Index()
        {
            var model = new RideViewModel();
            return View(model);
        }

        [HttpPost]
        public JsonResult CalculateTaxiFare(RideViewModel rideViewModel)
        {
            var totalPrice = _fareCalculatorService.Calculate(Mapper.Map<RideViewModel, RideHistory>(rideViewModel));
            rideViewModel.TotalPrice = totalPrice;
            return BetterJson(rideViewModel);
        }
    }
}