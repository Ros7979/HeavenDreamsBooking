using HeavenDreamsBooking.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

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
            var flights = await _flightService.AllFlights();
            return View(flights);
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
