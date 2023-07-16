using System;
using System.Collections.Generic;

#nullable disable

namespace Models
{
    public partial class MedicalRecord
    {
        public MedicalRecord()
        {
            ServiceMores = new HashSet<ServiceMore>();
        }

        public int RecordId { get; set; }
        public int BookingId { get; set; }
        public double TotalFee { get; set; }
        public int PatientId { get; set; }

        public virtual ICollection<ServiceMore> ServiceMores { get; set; }
    }
}
