using HeavenDreansBookingTest.Attributes;
using System.ComponentModel.DataAnnotations;
using static HeavenDreamsBooking.Infrastructure.Constants.DataConstants.FltDetailsConst;
namespace HeavenDreamsBooking.Core.Models.Flight
{
    public class FlightFormModel
    {
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
        [Display(Name ="Flight image url")]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; } = null!;
             
        [Required]
        [IsGreater(ErrorMessage ="The date should be greater then the current date")]
        [DataType(DataType.DateTime)]
        public DateTime DepTime { get; set; }
             
        [Required]
        [IsGreater(ErrorMessage = "The date should be greater then the current date")]
        [DataType(DataType.DateTime)]
        public DateTime ArrTime { get; set; }

        [Required]
        [StringLength(AircraftTypeMaxLength, MinimumLength = AircraftTypeMinLength)]
        [Display(Name = "Aircraft type")]
        public string AircraftType { get; set; } = null!;

        [Required]
        [Display(Name = "Number of business class seats")]
        public int SeatsBusiness { get; set; }

        [Required]
        [Display(Name = "Number of economy class seats")]
        public int SeatsEconomy { get; set; }

        [Required]
        [Display(Name = "Price of business class seat")]
        public decimal FareBusiness { get; set; }

        [Required]
        [Display(Name = "Price of economy class seat")]
        public decimal FareEconomy { get; set; }
                
        [Required]
        public DateTime LaunchDate { get; set; }


    }
}
