using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HeavenDreamsBooking.Infrastructure.Constants.DataConstants.CanseledConstants;

namespace HeavenDreamsBooking.Infrastructure.Data.Models
{
    public class FlightCanseled
    {
        [Key]
        public int Id { get; set; } 
        
        [MaxLength(TicketNoMaxLength)]
        public string TicketNo { get; set; } = string.Empty;
        [Required]
        public int Refund { get; set; }

        /// <summary>
        /// The user made the reservation
        /// </summary>
        [Required]
        public int ProcessedById { get; set; }
        public ProcessedBy? ProcessedBy { get; set; }

        [Required]
        public DateTime CanselationDate { get; set; }

    }
}
