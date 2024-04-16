using HeavenDreamsBooking.Core.Contracts;
using HeavenDreamsBooking.Core.Models.Home;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HeavenDreamsBooking.Controllers
{
    public class HomeController : Controller
    {
       // private readonly ILogger<HomeController> _logger;
        private readonly IFlightService _flightService;

        public HomeController(IFlightService flightService)
        {
            _flightService = flightService;
        }

        public async Task<IActionResult> Index()
        {
            var flights =  _flightService.AllFlights();
            List<FlightIndexServiceModel> distinctList = new List<FlightIndexServiceModel>();
            Dictionary<string, IEnumerable<FlightIndexServiceModel>> dict = new Dictionary<string, IEnumerable<FlightIndexServiceModel>>();
            foreach (FlightIndexServiceModel flight in await flights)
            {
                string flight1 = flight.FltNo;
                bool exists = distinctList.Any(cf => cf.FltNo.ToLower().Contains(flight1.ToLower()));
                if (!exists)
                {
                    distinctList.Add(flight);
                }
            }
            return View(distinctList);
        }

        public IActionResult Privacy()
        {
            return View();
        }       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Error(int statusCode)
        {
            if (statusCode == 400)
            {
                return View("Error400");
            }
            if (statusCode == 401)
            {
                return View("Error401");
            }
            return View();
        }
    }
}
