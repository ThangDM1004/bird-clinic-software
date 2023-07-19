using System;
using System.Collections.Generic;

#nullable disable

namespace Models
{
    public partial class RegistrationSchedule
    {
        public string Username { get; set; }
        public DateTime Date { get; set; }

        public virtual Account UsernameNavigation { get; set; }
    }
}
