using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET93_EF_Assignment_2.Models
{
    internal class Attendee
    {
        public int AttendeeId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        #region Attendee has an address
        public Address FullAddress { get; set; }
        #endregion
    }
}
