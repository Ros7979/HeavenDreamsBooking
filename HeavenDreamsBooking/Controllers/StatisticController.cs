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

        public IActionResult Index()
        {
            return View();
        }
    }
}
