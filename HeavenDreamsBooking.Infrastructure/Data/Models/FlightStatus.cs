using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HeavenDreamsBooking.Infrastructure.Constants.DataConstants.FltStatusConst;

namespace HeavenDreamsBooking.Infrastructure.Data.Models
{
    public class FlightStatus
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(FltNoMaxLength)]
        public string FltNo { get; set; } = string.Empty;

        [Required]
        public int FlightDetailId { get; set; }

        [ForeignKey(nameof(FlightDetailId))]
        public FlightDetail? FlightDetail { get; set; }

        [Required]
        public DateTime DateOfJorney { get; set; }

        [Required]
        public int StatusEconomy { get; set; }

        public int WaitListedEconomy { get; set; }

        [Required]
        public int StatusBusiness { get; set; }


        public int WaitListedBusiness { get; set; }

    }
}
