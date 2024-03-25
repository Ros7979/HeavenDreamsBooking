using HeavenDreamsBooking.Core.Contracts;
using HeavenDreamsBooking.Core.Models.Flight;
using HeavenDreamsBooking.Core.Models.Home;
using HeavenDreamsBooking.Infrastructure.Data;
using HeavenDreamsBooking.Infrastrucure.Data;
using Microsoft.EntityFrameworkCore;

namespace HeavenDreamsBooking.Core.Services.Flight
{
    public class FlightService : IFlightService
    {
        private readonly HeavenDbContext _context;
        public FlightService(HeavenDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<FlightIndexServiceModel>> AllFlights()
        {
            return await _context.FlightDetails.OrderByDescending(c => c.Id)
                .Select(c => new FlightIndexServiceModel
                {
                    Id = c.Id,
                    From = c.From,
                    Destination = c.Destination,
                    ImageUrl = c.ImageUrl,
                }
                ).ToListAsync();
        }
        public async Task<List<FlightIndexServiceModel>> AllFlightsList()
        {
            return await _context.FlightDetails.OrderByDescending(c => c.Id)
                .Select(c => new FlightIndexServiceModel
                {
                    Id = c.Id,
                    From = c.From,
                    Destination = c.Destination,
                    ImageUrl = c.ImageUrl
                }
                ).ToListAsync();
        }

        public async Task<List<FlightDetailsModel>> AllFlightsDetail()
        {
            return await _context.FlightDetails.OrderByDescending(c => c.Id)
                .Select(c => new FlightDetailsModel
                {
                    Id = c.Id,
                    FltNo = c.FltNo,
                    From = c.From,
                    Destination = c.Destination,
                    ImageUrl = c.ImageUrl,
                    DepTime = c.DepTime,
                    ArrTime = c.ArrTime,
                    AircraftType = c.AircraftType,
                    SeatsBusiness = c.SeatsBusines,
                    SeatsEconomy = c.SeatsEconomy,
                    FareBusiness = c.FareBusines,
                    FareEconomy = c.FareEconomy,
                    LaunchDate = c.LaunchDate
                }
                ).ToListAsync();
        }
        public async Task EditAsync(int id, FlightFormModel _flight)
        {
            var flight = await _context.FlightDetails.FindAsync(id);
            if (flight != null)
            {
                flight.FltNo = _flight.FltNo;
                flight.From = _flight.From;
                flight.Destination = _flight.Destination;
                flight.ImageUrl = _flight.ImageUrl;
                flight.DepTime = _flight.DepTime;
                flight.ArrTime = _flight.ArrTime;
                flight.AircraftType = _flight.AircraftType;
                flight.SeatsBusines = _flight.SeatsBusiness;
                flight.SeatsEconomy = _flight.SeatsEconomy;
                flight.FareBusines = _flight.FareBusiness;
                flight.FareEconomy = _flight.FareEconomy;
                await _context.SaveChangesAsync();
            };
        }

        public async Task DeleteAsync(int id)
        {
            var flight = await _context.FlightDetails.FindAsync(id);
            if (flight != null)
            {
                _context.FlightDetails.Remove(flight);
            }
            await _context.SaveChangesAsync();
        }
        public async Task DiscountSet(DiscountSetModel discounts)
        {
            var discount = await _context.Discounts.FindAsync(1);
            if (discount != null)
            {
                discount.FareLimit = discounts.FareTotal;
                discount.TotalFlightsLimit = discounts.TotalFlights;
                discount.DiscountGiven = discounts.DiscountGiven;
                await _context.SaveChangesAsync();
            };
        }
    }
}
