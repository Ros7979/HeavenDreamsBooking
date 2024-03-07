using HeavenDreamsBooking.Core.Models.Home;

namespace HeavenDreamsBooking.Core.Contracts
{
    public interface IFlightService
    {
        Task<IEnumerable<FlightIndexServiceModel>> AllFlights();
    }
}
