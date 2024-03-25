using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HeavenDreamsBooking.Infrastructure.Constants.DataConstants.DiscuntConstants;
  

namespace HeavenDreamsBooking.Infrastructure.Data.Models
{
    public class Discount
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Fare count for discunt        
        /// </summary>
        [Required]
        [Column(TypeName = "decimal(7,2)")]
        public decimal FareLimit { get; set; }

        /// <summary>
        /// Flights count for discunt        
        /// </summary>
        [Required]
        [Range(0, TotalFlightsLimitMaxLength,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int TotalFlightsLimit { get; set;}

        /// <summary>
        /// Discount in %
        /// </summary>
        [Required]       
        [Range(DiscountsMinLength, DiscountsMaxLength,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public double DiscountGiven { get; set; }
    }
}
