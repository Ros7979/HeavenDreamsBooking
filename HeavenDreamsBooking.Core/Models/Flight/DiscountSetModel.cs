using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HeavenDreamsBooking.Infrastructure.Constants.DataConstants.DiscuntConstants;
namespace HeavenDreamsBooking.Core.Models.Flight
{
    public class DiscountSetModel
    {    
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "decimal(7,2)")]
        public decimal FareTotal { get; set; }
     
        [Required]
        [Range(0, TotalFlightsLimitMaxLength,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int TotalFlights{ get; set; }     

        [Required]
        [Display(Name = "Business discount")]
        [Range(DiscountsMinLength, DiscountsMaxLength,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public double DiscountGiven { get; set; }
     
    }
}
