using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeavenDreamsBooking.Infrastructure.Constants
{
    public class DataConstants
    {
        public class FltDetailsConst
        {
            public const int FltNoMinLength = 4;
            public const int FltNoMaxLength = 20;

            public const int OriginMinLength = 4;
            public const int OriginMaxLength = 200;

            public const int DestinationMinLength = 4;
            public const int DestinationMaxLength = 200;

            public const int AircraftTypeMinLength = 4;
            public const int AircraftTypeMaxLength = 100;
        }
        public class ReservationsConst
        {
            public const int TicketNoMinLength = 4;
            public const int TicketNoMaxLength = 20;

            public const int FltNoMinLength = 4;
            public const int FltNoMaxLength = 20;

            public const int ResClassMinLength = 3;
            public const int ResClassMaxLength = 10;

            public const int StatusMinLength = 3;
            public const int StatusMaxLength = 50;

            public const int NameMinLength = 3;
            public const int NameMaxLength = 300;

            public const int EmailMinLength = 8;
            public const int EmailMaxLength = 256;

            public const int DateOfJorneyMaxLength = 40;
        }
        public class FltStatusConst
        {
            public const int FltNoMinLength = 4;
            public const int FltNoMaxLength = 20;

            public const int StatusMinLength = 3;
            public const int StatusMaxLength = 10;
        }
        public class CanseledConstants
        {
            public const int TicketNoMinLength = 4;
            public const int TicketNoMaxLength = 20;

            public const int ProcessedMinLength = 2;
            public const int ProcessedMaxLength = 20;
        }

        public class RolesConstants
        {
            public const int RoleNameMinLength = 3;
            public const int RoleNameMaxLength = 256;
        }

        public const string DateTimeForm = "yyyy-MM-dd HH:mm";
        public const string TimeFormat = "HH:mm";
        public const string DateOnlyFormat = "yyyy-MM-dd";
        public const string StringLengthErrorMessage = "The field {0} must be between {2} and {1} characters long";
    }
}
