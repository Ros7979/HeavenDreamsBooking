using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static HeavenDreamsBooking.Infrastructure.Constants.DataConstants.ReservationsConst;
namespace HeavenDreamsBooking.Infrastructure.Data.Models
{
    public class FlightCanseled
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(FltNoMaxLength)]
        public string FltNo { get; set; } = string.Empty;

        [Required]
        public DateTime DateOfJorney { get; set; }

        [Required]
        public float Refund { get; set; }

        [Required]
        [MaxLength(EmailMaxLength)]
        [EmailAddress]
        public string? Email { get; set; }

        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string? UserId { get; set; }
        [Required]
        public IdentityUser User { get; set; } = null!;

        [Required]
        public DateTime CanselationDate { get; set; }

    }
}
