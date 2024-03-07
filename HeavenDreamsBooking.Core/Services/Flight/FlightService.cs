using HeavenDreamsBooking.Core.Contracts;
using HeavenDreamsBooking.Core.Models.Home;
using HeavenDreamsBookingTest.Infrastrucure.Data;
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
            return await _context.FlightDetails.OrderByDescending(c=>c.Id)
                .Select(c => new FlightIndexServiceModel
                {
                    Id = c.Id,
                    From = c.From,
                    Destination = c.Destination,
                    ImageUrl = c.ImageUrl
                }
                ).ToListAsync();
        }
    }
}
