using System;
using System.Collections.Generic;

#nullable disable

namespace Models
{
    public partial class Species
    {
        public Species()
        {
            PatientBirds = new HashSet<PatientBird>();
        }

        public int SpeciesId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PatientBird> PatientBirds { get; set; }
    }
}
