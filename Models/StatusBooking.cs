using System;
using System.Collections.Generic;

#nullable disable

namespace Models
{
    public partial class StatusBooking
    {
        public StatusBooking()
        {
            Bookings = new HashSet<Booking>();
        }

        public int StatusId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
