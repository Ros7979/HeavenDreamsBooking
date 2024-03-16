using HeavenDreamsBooking.Core.Models.Flight;
using HeavenDreamsBooking.Core.Models.Home;

namespace HeavenDreamsBooking.Core.Contracts
{
    public interface IFlightService
    {
        Task<IEnumerable<FlightIndexServiceModel>> AllFlights();
        Task<List<FlightIndexServiceModel>> AllFlightsList();
        Task<List<FlightDetailsModel>> AllFlightsDetail();
        Task EditAsync(int id, FlightFormModel _flight);
        Task DeleteAsync(int id);
    }
}
