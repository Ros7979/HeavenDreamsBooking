using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HeavenDreamsBooking.Infrastructure.Constants.DataConstants.FltDetailsConst;
namespace HeavenDreamsBooking.Infrastructure.Data.Models
{
    public class FlightDetail
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Number of the flight
        /// </summary>
        [Required]
        [MaxLength(FltNoMaxLength)]
        public string FltNo { get; set; } = null!;

        /// <summary>
        /// Origin Destination
        /// </summary>
        [Required]
        [MaxLength(OriginMaxLength)]
        public string From { get; set; } = null!;

        /// <summary>
        /// Flight Destination
        /// </summary>
        [Required]
        [MaxLength(DestinationMaxLength)]
        public string Destination { get; set; } = null!;

        [Required]
        [Comment("Flight image url")]
        public string ImageUrl { get; set; }= null!;     

        /// <summary>
        /// Departure time
        /// </summary>
        [Required]
        public DateTime DepTime { get; set; }

        /// <summary>
        /// Arrival time
        /// </summary>
        [Required]
        public DateTime ArrTime { get; set; }

        [Required]
        [MaxLength(AircraftTypeMaxLength)]
        public string AircraftType { get; set; } = null!;
        [Required]
        public int SeatsBusines { get; set; }
     
        [Required]
        public int SeatsEconomy { get; set; }

        [Required]
        [Column(TypeName ="decimal(5,2)")]
        public decimal FareBusines { get; set; }

        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal FareEconomy { get; set; }

        /// <summary>
        /// Flight opening date
        /// </summary>
        [Required]
        public DateTime LaunchDate { get; set; }
        public IEnumerable<Reservation> Reservations { get; set; } = new List<Reservation>();
       // public IEnumerable<FlightStatus> FlightStatuses { get; set; } = new List<FlightStatus>();
    }
}
