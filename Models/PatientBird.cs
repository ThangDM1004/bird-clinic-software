using System;
using System.Collections.Generic;

#nullable disable

namespace Models
{
    public partial class PatientBird
    {
        public PatientBird()
        {
            Bookings = new HashSet<Booking>();
        }

        public int PatientId { get; set; }
        public int SpeciesId { get; set; }
        public string Username { get; set; }
        public bool Status { get; set; }
        public int? Age { get; set; }
        public double? Weight { get; set; }
        public double? Height { get; set; }
        public bool? Gender { get; set; }
        public string BirdName { get; set; }

        public virtual Species Species { get; set; }
        public virtual Account UsernameNavigation { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
