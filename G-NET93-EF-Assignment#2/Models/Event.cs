using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET93_EF_Assignment_2.Models
{
    internal class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime? EndDate { get; set; }
        public int MaxNumberOfAttendees { get; set; }

        #region Event Created by Organizer
        public Organizer Organizer { get; set; } = null!;
        public int OrganizerId { get; set; }
        #endregion
    }
}
