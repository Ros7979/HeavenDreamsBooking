using HeavenDreamsBooking.Core.Enumerations;
using System.ComponentModel.DataAnnotations;
using static HeavenDreamsBooking.Infrastructure.Constants.DataConstants;
using static HeavenDreamsBooking.Infrastructure.Constants.DataConstants.ReservationsConst;
namespace HeavenDreamsBooking.Core.Models.Reservation
{
    public class AddReservationBook
    {
        [Required]
        public int Id { get; set; }
        public string FltNo { get; set; } = string.Empty;
        public string DateOfJorney { get; set; } = string.Empty;
        [Required]
        public FlightClass ClassOfRes { get; set; }
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength, ErrorMessage = StringLengthErrorMessage)]
        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
        public decimal Fare { get; set; }
    }
}
