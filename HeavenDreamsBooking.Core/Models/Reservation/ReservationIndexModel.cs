namespace HeavenDreamsBooking.Core.Models.Reservation
{
    public class ReservationIndexModel
    {
        public int Id { get; set; }

        public string FltNo { get; set; } = null!;
        public string From { get; set; } = null!;
        public string Destination { get; set; } = null!;
        public DateTime DepTime { get; set; }
        public decimal FareBusines { get; set; }
        public decimal FareEconomy { get; set; }
    }
}
