using System;
using System.Collections.Generic;

#nullable disable

namespace Models
{
    public partial class Account
    {
        public Account()
        {
            RegistrationSchedules = new HashSet<RegistrationSchedule>();
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public bool Status { get; set; }
        public int Gender { get; set; }

        public virtual Gender GenderNavigation { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<RegistrationSchedule> RegistrationSchedules { get; set; }
    }
}
