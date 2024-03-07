using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HeavenDreamsBooking.Infrastructure.Constants.DataConstants.ReservationsConst;
namespace HeavenDreamsBooking.Infrastructure.Data.Models
{
    public class RegularFlier
    {
        /// <summary>
        /// Regular flier identifier
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Email of passenger
        /// </summary>
        ///         
        [MaxLength(EmailMaxLength)]
        public string Email { get; set; } = null!;
        /// <summary>
        /// Regular client discount
        /// </summary>
        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal Discount { get; set; }

        [Required]
        public int PassengerDetailId { get; set; }
        [ForeignKey(nameof(PassengerDetailId))]
        public PassengerDetail PassengerDetail { get; set; }=null!;

    }
}
