using HeavenDreamsBooking.Core.Contracts;
using HeavenDreamsBooking.Core.Enumerations;
using HeavenDreamsBooking.Core.Models.Flight;
using HeavenDreamsBooking.Core.Models.Reservation;
using HeavenDreamsBooking.Infrastructure.Constants;
using HeavenDreamsBooking.Infrastructure.Data.Models;
using HeavenDreamsBooking.Infrastrucure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace HeavenDreansBookingTest.Controllers
{
    [Authorize(Roles = "Employee")]
    public class EmployeeController : Controller
    {
        private readonly IFlightService _flightService;
        private readonly HeavenDbContext _context;
        private readonly IEmployeeService _employeeService;
        private readonly UserManager<IdentityUser> _userManager;
        public EmployeeController(IFlightService flightService, HeavenDbContext context, IEmployeeService employeeService, UserManager<IdentityUser> userManager)
        {
            _flightService = flightService;
            _context = context;
            _employeeService = employeeService;
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> SearchBy(string from, string to, DateTime dateOftravel)
        {
            var flightsDetails = await _flightService.AllFlightsDetail();
            if (flightsDetails.Count == 0)
            {
                TempData["InfoMessage"] = "Currently flights not available";
                return View();
            }
            else
            {
                if (string.IsNullOrEmpty(from))
                {
                    TempData["InfoMessage"] = "Please enter a From city.";
                    return View();

                }
                if (string.IsNullOrEmpty(to))
                {
                    TempData["InfoMessage"] = "Please enter a To city.";
                    return View();

                }
                if (dateOftravel == default)
                {
                    TempData["InfoMessage"] = "Please enter a Depart date.";
                    return View();
                }

                if (!string.IsNullOrEmpty(from) && !string.IsNullOrEmpty(to) && dateOftravel != default)
                {
                    var searchValueFlightFrom = flightsDetails.FirstOrDefault(fd => fd.From.ToLower().Contains(from.ToLower()) && fd.Destination.ToLower().Contains(to.ToLower()) && fd.DepTime.ToString("dd/MM/yyyy") == dateOftravel.ToString("dd/MM/yyyy"));
                    if (searchValueFlightFrom != null)
                    {
                        var flightStatus = _context.FlightStatus.FirstOrDefault(fs => fs.FlightDetailId == searchValueFlightFrom.Id);
                        FlightModelFlightStatus flightModelFlightStatus = new FlightModelFlightStatus()
                        {
                            Id = searchValueFlightFrom.Id,
                            FltNo = searchValueFlightFrom.FltNo,
                            From = searchValueFlightFrom.From,
                            Destination = searchValueFlightFrom.Destination,
                            ImageUrl = searchValueFlightFrom.ImageUrl,
                            DepTime = searchValueFlightFrom.DepTime,
                            ArrTime = searchValueFlightFrom.ArrTime,
                            AircraftType = searchValueFlightFrom.AircraftType,
                            SeatsBusiness = searchValueFlightFrom.SeatsBusiness,
                            SeatsEconomy = searchValueFlightFrom.SeatsEconomy,
                            FareBusiness = searchValueFlightFrom.FareBusiness,
                            FareEconomy = searchValueFlightFrom.FareEconomy,
                            LaunchDate = searchValueFlightFrom.LaunchDate,
                            FlightStatus = flightStatus
                        };
                        return View(flightModelFlightStatus);
                    }
                    else
                    {
                        TempData["InfoMessage"] = "There is no flight with this data.";
                        return View();
                    }
                }
                else
                {
                    TempData["InfoMessage"] = "There is no flight with this data.";
                    flightsDetails = null;
                    return View(flightsDetails);
                }
            }
        }
        [HttpGet]
        public async Task<IActionResult> AddReservation(int id)
        {            
            FlightDetail? getFlight = await _context.FlightDetails.FindAsync(id);
            string username = User.Identity?.Name!;
            if (username == null)
            {
                return Unauthorized();
            }
            if (getFlight == null)
            {
                return BadRequest();
            }          
            AddReservationBook reservation = new AddReservationBook()
            {
                Id = id,
                FltNo = getFlight.FltNo,
                DateOfJorney = getFlight.DepTime.ToString(DataConstants.DateTimeForm),
            };
            return View(reservation);
        }

        [HttpPost]
        public async Task<IActionResult> AddReservation(int id, AddReservationBook addReservation)
        {
            if (!ModelState.IsValid) { return BadRequest(); }
            decimal fare = 0.0m;
            decimal isNotRegular = 0.0m;
            string status = string.Empty;
            string email = User.FindFirstValue(ClaimTypes.Email);
            var flight = await _context.FlightDetails.FindAsync(id);
            var flightStatus = await _context.FlightStatus.FindAsync(id);
            var regular = _context.RegularFliers.FirstOrDefault(e => e.Email.Trim() == email.Trim());
            if (regular == null)
            {
                isNotRegular = 0.0m;
            }
            else
            {
                isNotRegular = (decimal)regular!.Discount / 100.0m;
            }
            var reservationExist = _context.Reservations.Where(r => r.FlightDetailsId == id && r.Email.Trim() == addReservation.Email.Trim());
            if (reservationExist.Any())
            {
                TempData["InfoMessage"] = "You have already booked that flight for this client";
                return View();
            }
            else
            {
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
                    var minusDiscountEco = isNotRegular * flight.FareEconomy;
                    fare = flight.FareEconomy - minusDiscountEco;
                    if (flightStatus?.StatusEconomy == 0)
                    {
                        status = "Wait Listed";
                    }
                    else
                    {
                        status = "Reserved not confirmed";
                    }
                }
                else
                {
                    var minusDiscountBis = isNotRegular * flight.FareBusines;
                    fare = flight.FareBusines - minusDiscountBis;
                    if (flightStatus?.StatusBusiness == 0)
                    {
                        status = "Wait Listed";
                    }
                    else
                    {
                        status = "Reserved not confirmed";
                    }
                }
                Reservation reservation = new Reservation()
                {
                    FltNo = flight.FltNo,
                    DateOfJorney = flight.DepTime,
                    Email = addReservation.Email.Trim(),
                    Name = addReservation.Name.Trim(),
                    ClassOfRes = addReservation.ClassOfRes.ToString(),
                    Fare = fare,
                    Status = status,
                    DateOfRes = DateTime.Now,
                    TicketConfirmed = false,
                    FlightDetailsId = flight.Id,
                    UserId = GetUserId()
                };
                string message = "Data not saved";
                try
                {
                    await _context.Reservations.AddAsync(reservation);
                    int result = _context.SaveChangesAsync().Result;
                    if (result > 0)
                    {
                        _employeeService.AddChangeFlightStatus(flight.Id, addReservation.ClassOfRes.ToString());
                    }
                }
                catch (Exception ex)
                {
                    message = ex.Message;
                }
                return View("SearchBy");
            }
        }

        [HttpGet]
        public  async Task<IActionResult> PostReservation(string mail)
        {
            List<Reservation> allClientReservation = new List<Reservation>();
            if (string.IsNullOrEmpty(mail))
            {
                TempData["InfoMessage"] = "Please enter an Email address.";
                return View();
            }
            else
            {
                allClientReservation =  _context.Reservations.Where(cr => cr.Email == mail.Trim()).ToList();
                if (allClientReservation == null)
                {
                    TempData["InfoMessage"] = "These person there is no any reservation or wrong email address.";
                    return View();
                }
            }

            return View(allClientReservation);
        }

        [HttpPost]
        public async Task<IActionResult> PostReservation(int id)
        {
            string message = "Data not confirmed";
            var reservationData = await _context.Reservations.FindAsync(id);
            if (reservationData == null) { return BadRequest(); }
            string? mail = reservationData.Email;
            if (mail == null) { return BadRequest(); }
            if (!_context.PassengerDetails.Any(r => r.Email.ToLower().Trim() == mail.ToLower().Trim()))
            {
                PassengerDetail passenger = new PassengerDetail()
                {
                    Email = mail.Trim(),
                    RegularFlier = new RegularFlier()
                    {
                        Email = mail.Trim()
                    }
                };
                try
                {
                    await _context.PassengerDetails.AddAsync(passenger);
                    await _context.SaveChangesAsync();
                }
                catch (Exception ex) { message = ex.Message; }
            };
            reservationData.Status = "Confirmed";
            reservationData.TicketConfirmed = true;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex) { message = ex.Message; }
            var passengerId = _context.PassengerDetails.SingleOrDefault(r => r.Email.ToLower().Trim() == mail.ToLower().Trim());
            DeparturedFlight departuredFlight = new DeparturedFlight()
            {
                FltNo = reservationData.FltNo,
                FlightDetailsId = reservationData.FlightDetailsId,
                DateOfJorney = reservationData.DateOfJorney,
                ClassOfRes = reservationData.ClassOfRes,
                Name = reservationData.Name,
                Email = reservationData.Email,
                Fare = reservationData.Fare,
                Status = reservationData.Status,
                UserId = reservationData.UserId,
                DateOfRes = reservationData.DateOfRes,
                TicketConfirmed = reservationData.TicketConfirmed,
                PassengerDetailsId = passengerId!.Id
            };
            await _context.DeparturedFlights.AddAsync(departuredFlight);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch { DbUpdateConcurrencyException due; }
            { }           
            if (passengerId != null)
            {
                passengerId.TotalTimesFlown += 1;
                passengerId.FareCollected += reservationData.Fare;
                passengerId.Name = reservationData.Name;
                try
                {
                 await   _context.SaveChangesAsync();
                }
                catch { DbUpdateConcurrencyException due; }
                { }               
                var regularFlier = _context.RegularFliers.Find(passengerId.Id);               
                var discountSetSmall = _context.Discounts.Find(1);
                if (passengerId?.FareCollected > discountSetSmall?.FareLimit | (passengerId?.TotalTimesFlown > discountSetSmall?.TotalFlightsLimit))
                {
                    regularFlier!.Discount = discountSetSmall!.DiscountGiven;
                    try
                    {
                       await _context.SaveChangesAsync();
                    }
                    catch { DbUpdateConcurrencyException due; }
                    { }
                }
            }
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var task = await _context.Reservations.FindAsync(id);
            if (task == null) { BadRequest(); }
            else
            {
                try
                {
                    _context.Reservations.Remove(task);
                    await _context.SaveChangesAsync();
                    _employeeService.CancelChangeFlightStatus(task.FlightDetailsId, task.ClassOfRes);
                }
                catch (Exception ex)
                {
                }
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Canceling(int id)
        {
            var reservationData = await _context.Reservations.FindAsync(id);
            if (reservationData == null) { return BadRequest(); }
            var refund = (90.0m / 100.0m) * reservationData.Fare;
            FlightCanseled flightCanseled = new FlightCanseled()
            {
                FltNo = reservationData.FltNo,
                DateOfJorney = reservationData.DateOfJorney,
                Email = reservationData.Email,
                Name = reservationData.Name,
                UserId = reservationData.UserId,
                CanselationDate = DateTime.Now,
                Refund = (float)refund
            };
            await _context.FlightsCanseled.AddAsync(flightCanseled);
            _context.Reservations.Remove(reservationData);
            await _context.SaveChangesAsync();
            _employeeService.CancelChangeFlightStatus(reservationData.FlightDetailsId, reservationData.ClassOfRes);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> ChangeStatus(int id)
        {
            var reservationWaitListed = await _context.Reservations.FindAsync(id);
            if (reservationWaitListed != null)
            {
                reservationWaitListed.Status = "Reserved not confirmed";
                await _context.SaveChangesAsync();
                _employeeService.ChangeWaitListedStatus(reservationWaitListed.FlightDetailsId, reservationWaitListed.ClassOfRes);
            }
            return View();
        }
        private string GetUserId() => User.FindFirstValue(ClaimTypes.NameIdentifier);
    }
}
