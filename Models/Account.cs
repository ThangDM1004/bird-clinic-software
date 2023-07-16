using System;
using System.Collections.Generic;

#nullable disable

namespace Models
{
    public partial class Account
    {
        public Account()
        {
            Bookings = new HashSet<Booking>();
            PatientBirds = new HashSet<PatientBird>();
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool Status { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<PatientBird> PatientBirds { get; set; }
    }
}
