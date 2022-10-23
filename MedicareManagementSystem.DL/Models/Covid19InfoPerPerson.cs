using System;
using System.Collections.Generic;

namespace MedicareManagementSystem.DAL.Models
{
    public partial class Covid19InfoPerPerson
    {
        public Covid19InfoPerPerson()
        {
            VaccinesPerPerson = new HashSet<VaccinesPerPerson>();
        }

        public string PersonId { get; set; }
        public string Covid19PersonalCode { get; set; }
        public DateTime? IsPositiveToCovidDate { get; set; }
        public DateTime? RecoveryDate { get; set; }

        public virtual PersonalData Person { get; set; }
        public virtual ICollection<VaccinesPerPerson> VaccinesPerPerson { get; set; }
    }
}
