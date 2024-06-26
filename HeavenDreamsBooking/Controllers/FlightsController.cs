﻿using HeavenDreamsBooking.Core.Contracts;
using HeavenDreamsBooking.Core.Models.Flight;
using HeavenDreamsBooking.Infrastructure.Data.Models;
using HeavenDreamsBooking.Infrastrucure.Data;
using Microsoft.AspNetCore.Mvc;

namespace HeavenDreansBookingTest.Controllers
{
    // [Authorize(Roles = "BusinessManager")]
    public class FlightsController : Controller
    {
        private readonly IFlightService _flightService;
        private readonly HeavenDbContext _context;
        public FlightsController(IFlightService flightService, HeavenDbContext context)
        {
            _flightService = flightService;
            _context = context;
        }
        public async Task<IActionResult> Index(string searchValue, DateTime deptime, DateTime arrtime)
        {
            var countFlights = await _flightService.AllFlightsList();
            var searchFlight = countFlights.Where(cf => cf.From.ToLower().Contains(searchValue.ToLower()));
            return View(countFlights);
        }

        public async Task<IActionResult> Details(string searchBy, string searchValue)
        {
            var flightsDetails = await _flightService.AllFlightsDetail();
            if (flightsDetails.Count == 0)
            {
                TempData["InfoMessage"] = "Currently flights not available";
            }
            else
            {
                if (string.IsNullOrEmpty(searchValue))
                {
                    TempData["InfoMessage"] = "Please provide search value.";
                    return View(flightsDetails);
                }
                else
                {
                    if (searchBy.ToLower() == "flighno")
                    {
                        //var hj = flightsDetails.Where(gt => gt.DepTime.ToString("dd/MM/yyyy") == searchValue);
                        var searchValueFlightNo = flightsDetails.Where(fd => fd.FltNo.ToLower().Contains(searchValue.ToLower())).ToList();
                        return View(searchValueFlightNo);
                    }
                    else if (searchBy.ToLower() =="from")
                    {                       
                        var searchValueFlightFrom = flightsDetails.Where(fd => fd.From.ToLower().Contains(searchValue.ToLower())).ToList();
                        return View(searchValueFlightFrom);
                    }
                    else if (searchBy.ToLower() == "destination")
                    {
                        var searchValueFlightDest = flightsDetails.Where(fd => fd.Destination.ToLower().Contains(searchValue.ToLower())).ToList();
                        return View(searchValueFlightDest);
                    }
                }
            }
            return View(flightsDetails);
        }

        [HttpGet]
        public IActionResult Add() => View();

        [HttpPost]
        public async Task<IActionResult> Add(FlightFormModel flightFormModel)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var flightAdd = new FlightDetail()
            {
                FltNo = flightFormModel.FltNo,
                From = flightFormModel.From,
                Destination = flightFormModel.Destination,
                ImageUrl = flightFormModel.ImageUrl,
                DepTime = flightFormModel.DepTime,
                ArrTime = flightFormModel.ArrTime,
                AircraftType = flightFormModel.AircraftType,
                SeatsBusines = flightFormModel.SeatsBusiness,
                SeatsEconomy = flightFormModel.SeatsEconomy,
                FareBusines = flightFormModel.FareBusiness,
                FareEconomy = flightFormModel.FareEconomy,
                LaunchDate = DateTime.Now,
                FlightStatus = new FlightStatus()
                {
                    FltNo = flightFormModel.FltNo.Trim(),
                    DateOfJorney = flightFormModel.DepTime,
                    StatusEconomy = flightFormModel.SeatsEconomy,
                    StatusBusiness = flightFormModel.SeatsBusiness,
                    WaitListedEconomy = 0,
                    WaitListedBusiness = 0
                }
            };
            await _context.FlightDetails.AddAsync(flightAdd);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var flight = await _context.FlightDetails.FindAsync(id);
            if (flight == null)
            {
                return BadRequest();
            }
            FlightFormModel flightFormModel = new FlightFormModel()
            {
                FltNo = flight.FltNo,
                From = flight.From,
                Destination = flight.Destination,
                ImageUrl = flight.ImageUrl,
                DepTime = flight.DepTime,
                ArrTime = flight.ArrTime,
                AircraftType = flight.AircraftType,
                SeatsBusiness = flight.SeatsBusines,
                SeatsEconomy = flight.SeatsEconomy,
                FareBusiness = flight.FareBusines,
                FareEconomy = flight.FareEconomy
            };
            return View(flightFormModel);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, FlightFormModel _flight)
        {
            var flight = await _context.FlightDetails.FindAsync(id);
            if (flight == null)
            {
                return this.View();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _flightService.EditAsync(id, _flight);
            return View("Details");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var flightExist = await _context.FlightDetails.FindAsync(id);
            if (flightExist == null)
            {
                return BadRequest();
            };
            FlightDetailsModel flightFormModel = new FlightDetailsModel()
            {
                Id = flightExist.Id,
                FltNo = flightExist.FltNo,
                From = flightExist.From,
                Destination = flightExist.Destination,
                ImageUrl = flightExist.ImageUrl,
                DepTime = flightExist.DepTime,
                ArrTime = flightExist.ArrTime,
                AircraftType = flightExist.AircraftType,
                SeatsBusiness = flightExist.SeatsBusines,
                SeatsEconomy = flightExist.SeatsEconomy,
                FareBusiness = flightExist.FareBusines,
                FareEconomy = flightExist.FareEconomy
            };
            return View(flightFormModel);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(FlightDetailsModel _flight)
        {
            if( await _context.FlightDetails.FindAsync(_flight.Id) == null)
            {
                return BadRequest();
            }
            await _flightService.DeleteAsync(_flight.Id);
            return View("Details");
        }

        [HttpGet]
        public async Task<IActionResult> DiscountsSet()
        {
            var lowDiscount = await _context.Discounts.FindAsync(1);
            if (lowDiscount == null)
            {
                return BadRequest();
            }
            DiscountSetModel discountSet = new DiscountSetModel()
            {
                Id = lowDiscount.Id,
                FareTotal = lowDiscount.FareLimit,
                TotalFlights = lowDiscount.TotalFlightsLimit,
                DiscountGiven = lowDiscount.DiscountGiven
            };
            return View(discountSet);
        }
        [HttpPost]
        public async Task<IActionResult> DiscountsSet(DiscountSetModel discounts)
        {
            if (!ModelState.IsValid) { return BadRequest(); }
            await _flightService.DiscountSet(discounts);
            return View();
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
    }
}
