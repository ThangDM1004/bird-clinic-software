using System;
using System.Collections.Generic;

#nullable disable

namespace Models
{
    public partial class Gender
    {
        public Gender()
        {
            Accounts = new HashSet<Account>();
            PatientBirds = new HashSet<PatientBird>();
        }

        public int Gender1 { get; set; }
        public string GenderName { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<PatientBird> PatientBirds { get; set; }
    }
}
