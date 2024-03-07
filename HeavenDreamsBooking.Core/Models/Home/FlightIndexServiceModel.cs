using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeavenDreamsBooking.Core.Models.Home
{
    public class FlightIndexServiceModel
    {
        public int Id { get; set; }
        public string From { get; set; } = string.Empty;
        public string Destination { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }
}
