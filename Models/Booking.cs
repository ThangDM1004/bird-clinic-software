using System;
using System.Collections.Generic;

#nullable disable

namespace Models
{
    public partial class Booking
    {
        public int BookingId { get; set; }
        public DateTime BookingDate { get; set; }
        public int StatusId { get; set; }
        public string UsernameDoctor { get; set; }
        public string UsernameCustomer { get; set; }
        public int ServiceId { get; set; }
        public double? Fee { get; set; }
        public int? PatiendId { get; set; }

        public virtual PatientBird Patiend { get; set; }
        public virtual Service Service { get; set; }
        public virtual StatusBooking Status { get; set; }
        public virtual Account UsernameCustomerNavigation { get; set; }
    }
}
