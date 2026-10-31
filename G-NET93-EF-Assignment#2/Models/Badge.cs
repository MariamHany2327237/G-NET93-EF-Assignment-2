using G_NET93_EF_Assignment_2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET93_EF_Assignment_2.Models
{
    internal class Badge
    {
        public int BadgeNumber { get; set; }
        public DateTime IssuedDate { get; set; }
        public Tier Tier { get; set; }

        #region Badge Belong to Attendee
        public Attendee OwnerAttendee { get; set; } = null!;
        public int OwnerAttendeeId { get; set; }
        #endregion
    }
}
