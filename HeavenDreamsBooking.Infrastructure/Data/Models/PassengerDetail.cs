using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HeavenDreamsBooking.Infrastructure.Constants.DataConstants.ReservationsConst;
namespace HeavenDreamsBooking.Infrastructure.Data.Models
{
    public class PassengerDetail
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Email of passenger
        /// </summary>
        ///        
        [MaxLength(EmailMaxLength)]
        public string Email { get; set; } = null!;

        /// <summary>
        /// Name of passenger
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = string.Empty;       
        
        [Required]
        [Column(TypeName = "decimal(7,2)")]
        public decimal FareCollected { get; set; }
        [Required]
        public int TotalTimesFlown { get; set; }
        public IEnumerable<DeparturedFlight> DeparturedFlights { get; set; }=new List<DeparturedFlight>();
        public RegularFlier? RegularFlier { get; set; }
    }
}
