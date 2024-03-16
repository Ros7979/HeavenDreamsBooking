using System.ComponentModel.DataAnnotations;
using HeavenDreansBookingTest;

namespace HeavenDreansBookingTest.Attributes
{
    public class IsGreater :ValidationAttribute
    {
        private readonly DateTime todayDate=DateTime.Today;        
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null && (DateTime)value >= todayDate)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(ErrorMessage);
        }
    }
}
