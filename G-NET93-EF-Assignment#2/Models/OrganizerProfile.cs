using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET93_EF_Assignment_2.Models
{
    internal class OrganizerProfile
    {
        public int OrganizerProfileId { get; set; }
        public string Biography { get; set; } = null!;
        public string CompanyWebsite { get; set; } = null!;
        public string Logo { get; set;} = null!;

        #region Profile belong to Organizer
        public Organizer OwnerOrganizer { get; set; } = null!;

        public int OwnerOrganizerId { get; set; }
        #endregion
    }
}
