using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HeavenDreamsBooking.Infrastructure.Data.Models
{
    public class ProcessedBy
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PhoneNumber { get; set; } = null!;
        public string? Email { get; set; }

        [Required]
        public string? UserId { get; set; }
        [Required]
        public IdentityUser User { get; set; } = null!;

       // public IEnumerable<Reservation> Reservations { get; set; }=new List<Reservation>();

    }
}
