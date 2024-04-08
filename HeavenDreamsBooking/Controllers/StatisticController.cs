using HeavenDreamsBooking.Core.Models.Statistic;
using HeavenDreamsBooking.Infrastrucure.Data;
using Microsoft.AspNetCore.Mvc;

namespace HeavenDreansBookingTest.Controllers
{
    public class StatisticController : Controller
    {
        private readonly HeavenDbContext _context;
        public StatisticController(HeavenDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> PassengerFlightsDetail(string searchValue)
        {
            PassengerFlightsDetailModel init = new PassengerFlightsDetailModel()
            {
                FareCollected = 0.0m,
                TotalTimesFlown = 0,
                FlierDiscount = 0.0
            };
            if (string.IsNullOrEmpty(searchValue))
            {
                TempData["InfoMessage"] = "Please provide search value.";
                return View();
            }
            else
            {
                var passengerDetail = _context.PassengerDetails.FirstOrDefault(pd => pd.Email.ToLower().Trim() == searchValue.ToLower().Trim());
                var regularFlier = await _context.RegularFliers.FindAsync(passengerDetail?.Id);
                if (passengerDetail == null || regularFlier == null)
                {
                    TempData["InfoMessage"] = "Currently there is no passenger with this data available";
                }
                else
                {
                    PassengerFlightsDetailModel model = new PassengerFlightsDetailModel()
                    {
                        FareCollected = passengerDetail.FareCollected,
                        TotalTimesFlown = passengerDetail.TotalTimesFlown,
                        FlierDiscount = regularFlier.Discount
                    };
                    return View(model);
                };
            }
            return View(init);
        }

        [HttpGet]
        public async Task<IActionResult> Report(string searchBy, string searchValue, DateTime dateFrom, DateTime dateTo)
        {
            decimal sumFare = 0.0m;
            int totalPassengers = 0;
            if (dateFrom == default)
            {
                TempData["InfoMessage"] = "Please enter a date From.";
                return View();
            }
            if (dateTo == default)
            {
                TempData["InfoMessage"] = "Please enter a date To.";
                return View();
            }
            if (!string.IsNullOrEmpty(searchBy))
            {
                if (searchBy.ToLower() == "flightno")
                {
                    if (!string.IsNullOrEmpty(searchValue))
                    {
                        sumFare = _context.DeparturedFlights.Where(dp => dp.FltNo.ToLower() == searchValue.ToLower() && dp.DateOfJorney >= dateFrom
                      && dp.DateOfJorney <= dateTo).ToList().Sum(dp => dp.Fare);
                        totalPassengers = _context.DeparturedFlights.Where(dp => dp.DateOfJorney >= dateFrom && dp.DateOfJorney <= dateTo).ToList().Count();
                    }
                    else
                    {
                        TempData["InfoMessage"] = "Please provide search value. Write Flight number.";
                        return View();
                    }
                }
                else
                {
                    sumFare = _context.DeparturedFlights.Where(dp => dp.DateOfJorney >= dateFrom
                     && dp.DateOfJorney <= dateTo).ToList().Sum(dp => dp.Fare);
                    totalPassengers = _context.DeparturedFlights.Where(dp => dp.DateOfJorney >= dateFrom && dp.DateOfJorney <= dateTo).ToList().Count();
                }
            }
            else
            {
                TempData["InfoMessage"] = "Please provide search value.";
                return View();
            }
            Reports reports = new Reports()
            {
                SumFare = sumFare,
                SumTotalPassengers = totalPassengers
            };
            return View(reports);
        }
    }
}
