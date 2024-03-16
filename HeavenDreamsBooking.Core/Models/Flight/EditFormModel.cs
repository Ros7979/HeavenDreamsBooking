using System.ComponentModel.DataAnnotations;
using static HeavenDreamsBooking.Infrastructure.Constants.DataConstants.FltDetailsConst;
namespace HeavenDreamsBooking.Core.Models.Flight
{
    public class EditFormModel
    {
        [Required]
        public string FindFltN { get; set; } = null!;
        [Required]
        public DateTime FindDepTime { get; set; }

        [Required]
        public DateTime FindArrTime { get; set; }

        [Required]
        [StringLength(FltNoMaxLength, MinimumLength = FltNoMinLength)]
        [Display(Name = "Flight number")]
        public string FltNo { get; set; } = null!;

        [Required]
        [StringLength(OriginMaxLength, MinimumLength = OriginMinLength)]
        [Display(Name = "Place of departure")]
        public string From { get; set; } = null!;

        [Required]
        [StringLength(DestinationMaxLength, MinimumLength = DestinationMinLength)]
        [Display(Name = "Landng place")]
        public string Destination { get; set; } = null!;

        [Required]
        [Display(Name = "Flight image url")]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public DateTime DepTime { get; set; }

        [Required]
        public DateTime ArrTime { get; set; }

        [Required]
        [StringLength(AircraftTypeMaxLength, MinimumLength = AircraftTypeMinLength)]
        [Display(Name = "Type of aircraft")]
        public string AircraftType { get; set; } = null!;

        [Required]
        [Display(Name = "Number of business class seats")]
        public int SeatsBusines { get; set; }

        [Required]
        [Display(Name = "Number of economy class seats")]
        public int SeatsEconomy { get; set; }

        [Required]
        [Display(Name = "Price of business class seat")]
        public decimal FareBusines { get; set; }

        [Required]
        [Display(Name = "Price of economy class seat")]
        public decimal FareEconomy { get; set; }

        [Required]
        public DateTime LaunchDate { get; set; }
    }
}
 