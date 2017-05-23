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

        public ActionResult Index(TaxiRateViewModel taxiRateViewModel)
        {
            var test = _fareCalculatorService.Calculate(Mapper.Map<TaxiRateViewModel, TaxiRate>(taxiRateViewModel));
            return View();
        }

        public ActionResult Calculate(TaxiRateViewModel taxiRateViewModel)
        {   
            return null;
        }
    }
}