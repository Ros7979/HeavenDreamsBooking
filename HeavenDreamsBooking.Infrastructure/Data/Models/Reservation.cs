using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HeavenDreamsBooking.Infrastructure.Constants.DataConstants.ReservationsConst;
namespace HeavenDreamsBooking.Infrastructure.Data.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Thicked number
        /// </summary>       
        [MaxLength(TicketNoMaxLength)]
        public string TicketNo { get; set; } = string.Empty;

        //[MaxLength(FltNoMaxLength)]
        //public string FltNo { get; set; } = string.Empty;

        [Required]        
        public int FlightDetailsId { get; set; } 

        [ForeignKey(nameof(FlightDetailsId))]
        public FlightDetail FlightDetail { get; set; } = null!;

        /// <summary>
        /// Date of travel
        /// </summary>
        [Required]
        public DateTime DateOfJorney { get; set; }

        /// <summary>
        /// Busines or Executive classes
        /// </summary>
        [Required]
        [MaxLength(ResClassMaxLength)]
        public string ClassOfRes { get; set; } = string.Empty;

        /// <summary>
        /// Name of passenger
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Email of passenger
        /// </summary>
        [MaxLength(EmailMaxLength)]
        public string? Email { get; set; }

        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal Fare { get; set; }
        [Required]
        public int Status { get; set; }

        /// <summary>
        /// The user made the reservation
        /// </summary>
        [Required]
        public int ProcessedById { get; set; }
        public ProcessedBy? ProcessedBy { get; set; }

        //[ForeignKey(nameof(ReservationId))]
        //public IdentityUser User { get; set; } = null!;

        /// <summary>
        /// Date of reservation
        /// </summary>
        [Required]
        public DateTime DateOfRes { get; set; }

        /// <summary>
        /// Ticked confirmation
        /// </summary>
        public bool? TicketConfirmed { get; set; }
        
    }
}
