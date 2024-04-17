namespace HeavenDreamsBooking.Core.Models.Home
{
    public class FlightIndexServiceModel
    {
        public int Id { get; set; }
        public string FltNo { get; set; } = null!;
        public string From { get; set; } = string.Empty;
        public string Destination { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }
}
