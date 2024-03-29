﻿using HeavenDreamsBooking.Core.Contracts;
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
            var regular = _context.RegularFliers.FirstOrDefault(e => e.Email.Trim() == email.Trim());
            var reservationExist = _context.Reservations.Where(r => r.FlightDetailsId == id);
            if (reservationExist.Any())
            {
                TempData["msg"] = "You have already booked that flight";
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
                    var minusDiscountEco = ((decimal)regular!.Discount / 100.0m) * flight.FareEconomy;
                    fare = flight.FareEconomy - minusDiscountEco;
                }
                else
                {
                    var minusDiscountBis = ((decimal)regular!.Discount / 100.0m) * flight.FareBusines;
                    fare = flight.FareEconomy - minusDiscountBis;
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
                await _context.PassengerDetails.AddAsync(passenger);
                await _context.SaveChangesAsync();
            };
            reservationData.Status = "Confirmed";
            reservationData.TicketConfirmed = true;
            await _context.SaveChangesAsync();
            var passengerId = _context.PassengerDetails.SingleOrDefault(r => r.Email.ToLower().Trim() == mail.ToLower().Trim());
            Infrastructure.Data.Models.DeparturedFlight departuredFlight = new Infrastructure.Data.Models.DeparturedFlight()
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
            await _context.SaveChangesAsync();
            FillPassengerDetail(mail, departuredFlight.Fare);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Canceling(int id)
        {
            var reserva = await _context.Reservations.FindAsync(id);
            if (reserva == null) { return BadRequest(); }
            return View(reserva);
        }
        [HttpPost]
        public async Task<IActionResult> Canceling(int id, Reservation reserv)
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
            return RedirectToAction("Index", "Home");
        }

        private void FillPassengerDetail(string email, decimal fare)
        {
            var passengerId = _context.PassengerDetails.SingleOrDefault(r => r.Email.ToLower().Trim() == email.ToLower().Trim());
            if (passengerId != null)
            {
                passengerId.TotalTimesFlown += 1;
                passengerId.FareCollected += fare;
                _context.SaveChangesAsync();
                RegularFlierFill(passengerId.Id);
            }
        }

        private void RegularFlierFill(int id)
        {
            var regularFlier = _context.RegularFliers.Find(id);
            var passengerDetail = _context.PassengerDetails.Find(id);
            var discountSetSmall = _context.Discounts.Find(1);
            var discountSetBig = _context.Discounts.Find(2);
            if (passengerDetail?.FareCollected > discountSetSmall?.FareLimit || passengerDetail?.TotalTimesFlown > discountSetSmall?.TotalFlightsLimit)
            {
                regularFlier!.Discount = discountSetSmall.DiscountGiven;
                _context.SaveChangesAsync();
            }
            //else if (passengerDetail?.FareCollected > discountSetBig?.FareLimit || passengerDetail?.TotalTimesFlown > discountSetBig?.TotalFlightsLimit)
            //{
            //    regularFlier!.Discount = discountSetBig.DiscountGiven;
            //    _context.SaveChangesAsync();
            //}
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

