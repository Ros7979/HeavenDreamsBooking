using HeavenDreamsBooking.Core.Models.Reservation;
using HeavenDreamsBooking.Infrastructure.Data.Models;

namespace HeavenDreamsBooking.Core.Contracts
{
    public interface IReservationService
    {
     public   Task<IEnumerable<ReservationIndexModel>> DestDetails(int id);
      public  IEnumerable<Reservation> ReservationClientDetails(string id);
    }
}
