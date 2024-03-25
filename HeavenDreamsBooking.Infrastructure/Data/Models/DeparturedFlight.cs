using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HeavenDreamsBooking.Infrastructure.Constants.DataConstants.ReservationsConst;
namespace HeavenDreamsBooking.Infrastructure.Data.Models
{
    public class DeparturedFlight
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Thicked number
        /// </summary>        
        [MaxLength(FltNoMaxLength)]
        public string FltNo { get; set; } = string.Empty;

        [Required]
        public int FlightDetailsId { get; set; }

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
        [Column(TypeName = "decimal(6,2)")]
        public decimal Fare { get; set; }
        [Required]
        public string Status { get; set; } = string.Empty;

        [Required]
        public string? UserId { get; set; }

        /// <summary>
        /// Date of reservation
        /// </summary>
        [Required]
        public DateTime DateOfRes { get; set; }

        /// <summary>
        /// Ticked confirmation
        /// </summary>
        public bool? TicketConfirmed { get; set; }

        [Required]
        public int PassengerDetailsId { get; set; }

        [ForeignKey(nameof(PassengerDetailsId))]
        public PassengerDetail PassengerDetail { get; set; } = null!;

    }
}
