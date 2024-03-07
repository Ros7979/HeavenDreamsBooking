using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HeavenDreamsBooking.Infrastructure.Constants.DataConstants.FltStatusConst;

namespace HeavenDreamsBooking.Infrastructure.Data.Models
{
    public class FlightStatus
    {
        [Key]
        public int Id { get; set; }
                
        public int FlightDetailId { get; set; }

        [ForeignKey(nameof(FlightDetailId))]
        public FlightDetail? FlightDetail { get; set; }

        [Required]
        public DateTime StatusDate { get; set; }
        [Required]
        [MaxLength(StatusMaxLength)]
        public string StatusClass { get; set; }= null!;
        [Required]
        public int Status { get; set; }

    }
}
