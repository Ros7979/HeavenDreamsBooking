using System.ComponentModel.DataAnnotations;
using static HeavenDreamsBooking.Infrastructure.Constants.DataConstants.RolesConstants;
namespace HeavenDreamsBooking.Core.Models.Admini
{
    public class AddRoleModel
    {        
        public string Id { get; set; }=string.Empty;
        [Required]
        [StringLength(RoleNameMaxLength, MinimumLength = RoleNameMinLength)]
        [Display(Name = "Role name")]
       public string Name { get; set; }=string.Empty;

        [StringLength(RoleNameMaxLength, MinimumLength = RoleNameMinLength)]
       public string NormalizedName { get; set; } = string.Empty;
    }
}
