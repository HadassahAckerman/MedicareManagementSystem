using System;
using System.Collections.Generic;

namespace MedicareManagementSystem.DAL.Models
{
    public partial class VaccinesTypes
    {
        public VaccinesTypes()
        {
            VaccinesPerPerson = new HashSet<VaccinesPerPerson>();
        }

        public int Type { get; set; }
        public string VaccineManufacturer { get; set; }

        public virtual ICollection<VaccinesPerPerson> VaccinesPerPerson { get; set; }
    }
}
