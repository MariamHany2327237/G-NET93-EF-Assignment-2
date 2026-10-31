using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET93_EF_Assignment_2.Models
{
    internal class Attendee
    {
        public int AttendeeId { get; set; }

        [Required]
        [MaxLength(150)]
        public string FullName { get; set; } = null!;

        [Required]
        [MaxLength(200)]
        public string Email { get; set; } = null!;

        #region Attendee has an address
        public Address Address { get; set; } = null!;

        [NotMapped]
        public string FullAddress => $"{Address.Street}, {Address.City}, {Address.Country}, {Address.PostalCode}";
        #endregion

        #region Attendee Has Badge
        public Badge? Badge { get; set; }
        #endregion
    }
}
