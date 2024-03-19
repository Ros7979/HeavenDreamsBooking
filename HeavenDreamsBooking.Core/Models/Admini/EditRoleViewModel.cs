using System.ComponentModel.DataAnnotations;

namespace HeavenDreamsBooking.Core.Models.Admini
{
    public class EditRoleViewModel
    {
        public string Id { get; set; } = string.Empty;
        [Required(ErrorMessage = "Role Name is required")]
        public string RoleName { get; set; } = string.Empty;
        public List<string> Users { get; set; } = new List<string>();
    }
}
