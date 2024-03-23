using HeavenDreamsBooking.Core.Contracts;
using HeavenDreamsBooking.Core.Models.Reservation;
using HeavenDreamsBooking.Infrastructure.Data.Models;
using HeavenDreamsBooking.Infrastrucure.Data;

namespace HeavenDreamsBooking.Core.Services.Reservation
{
    public class ReservationService : IReservationService
    {
        private readonly HeavenDbContext _context;
        public ReservationService(HeavenDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ReservationIndexModel>> DestDetails(int id)
        {
            var flight = await _context.FlightDetails.FindAsync(id); 
            if (flight == null) 
            {
                return Enumerable.Empty<ReservationIndexModel>();
            }
            string FltNo = flight.FltNo;
            List< FlightDetail > listFD = new List< FlightDetail >();        
            foreach (FlightDetail item in _context.FlightDetails)
            {
                if (item.FltNo.Trim() == FltNo.Trim()) 
                {
                    listFD.Add( item );
                }
                else
                {
                    continue;
                }
            }          
            return  listFD
                    .Select(c => new ReservationIndexModel
                    {
                        Id = c.Id,
                        FltNo = c.FltNo,
                        From = c.From,
                        Destination = c.Destination,
                        DepTime = c.DepTime,
                        FareBusines = c.FareBusines,
                        FareEconomy = c.FareEconomy
                    }).ToList();
        }             

       public IEnumerable<Infrastructure.Data.Models.Reservation> ReservationClientDetails(string id)
        {
            return  _context.Reservations.Where(r => r.UserId == id).ToList();
        }
    }
}
