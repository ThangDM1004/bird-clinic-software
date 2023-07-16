using System;
using System.Collections.Generic;

#nullable disable

namespace Models
{
    public partial class ServiceMore
    {
        public int RecordId { get; set; }
        public int ServiceId { get; set; }
        public double Fee { get; set; }

        public virtual MedicalRecord Record { get; set; }
        public virtual Service Service { get; set; }
    }
}
