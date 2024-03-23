using HeavenDreamsBooking.Core.Contracts;
using HeavenDreamsBooking.Core.Enumerations;
using HeavenDreamsBooking.Core.Models.Reservation;
using HeavenDreamsBooking.Infrastructure.Constants;
using HeavenDreamsBooking.Infrastructure.Data.Models;
using HeavenDreamsBooking.Infrastrucure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HeavenDreamsBooking.Controllers
{
    [Authorize]
    public class ReservationController : Controller
    {

        private readonly HeavenDbContext _context;
        private readonly IReservationService _reservationService;

        public ReservationController(HeavenDbContext context, IReservationService reservationService)
        {
            _context = context;
            _reservationService = reservationService;
        }
        [HttpGet]
        public async Task<IActionResult> DestDetails(int id)
        {
            var flight = await _reservationService.DestDetails(id);

            return View(flight);
        }

        [HttpGet]
        public async Task<IActionResult> AddReservation(int id)
        {
            var getFlight = GetFlight(id);
            string username = User.Identity?.Name!;
            var getUser = GetUserId();
            if (username == null)
            {
                return BadRequest();
            }
            string email = User.FindFirstValue(ClaimTypes.Email);
            if (getFlight == null)
            {
                return BadRequest();
            }
            ViewBag.Flight = getFlight.FareEconomy;
            ViewBag.Flight1 = getFlight.FareBusines;
            AddReservationBook reservation = new AddReservationBook()
            {
                Id = id,
                FltNo = getFlight.FltNo,
                DateOfJorney = getFlight.DepTime.ToString(DataConstants.DateTimeForm),
                Email = email

            };
            return View(reservation);
        }

        [HttpPost]
        public async Task<IActionResult> AddReservation(int id, AddReservationBook addReservation)
        {
            decimal fare = 0.0m;
            string email = User.FindFirstValue(ClaimTypes.Email);
            var flight = await _context.FlightDetails.FindAsync(id);
            if (flight == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            if (addReservation.ClassOfRes.ToString() == FlightClass.Economy.ToString())
            {
                fare = flight.FareEconomy;
            }
            else
            {
                fare = flight.FareBusines;
            }
            Reservation reservation = new Reservation()
            {
                FltNo = flight.FltNo,
                DateOfJorney = flight.DepTime,
                Email = email,
                Name = addReservation.Name,
                ClassOfRes = addReservation.ClassOfRes.ToString(),
                Fare = fare,
                Status = "Reserved not confirmed",
                DateOfRes = DateTime.Now,
                TicketConfirmed = false,
                FlightDetailsId = flight.Id,
                UserId = GetUserId()
            };
            await _context.Reservations.AddAsync(reservation);
            await _context.SaveChangesAsync();
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Confirmation()
        {
            var ident = GetUserId();
            var reservationsData = _reservationService.ReservationClientDetails(ident);
            if (reservationsData == null) { return BadRequest(); }
            return View(reservationsData);
        }
        [HttpPost]
        public async Task<IActionResult> Confirmation(int id)
        {
            var reservationData = await _context.Reservations.FindAsync(id);
            if (reservationData == null)
            {
                return BadRequest();
            }
            reservationData.Status = "Confirmed";
            reservationData.TicketConfirmed = true;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        private string GetUserId() => User.FindFirstValue(ClaimTypes.NameIdentifier);

        public IActionResult Index()
        {
            return View();
        }

        private FlightDetail GetFlight(int id)
        {
            return _context.FlightDetails.Find(id)!;

        }

    }
}
