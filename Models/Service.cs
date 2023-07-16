using System;
using System.Collections.Generic;

#nullable disable

namespace Models
{
    public partial class Service
    {
        public Service()
        {
            Bookings = new HashSet<Booking>();
            ServiceMores = new HashSet<ServiceMore>();
        }

        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public double Fee { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<ServiceMore> ServiceMores { get; set; }
    }
}
