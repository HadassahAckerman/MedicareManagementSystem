using System;
using System.Collections.Generic;

namespace MedicareManagementSystem.DAL.Models
{
    public partial class VaccinesPerPerson
    {
        public string VaccineNumber { get; set; }
        public string Covid19Id { get; set; }
        public DateTime VaccineDate { get; set; }
        public int VaccineType { get; set; }

        public virtual Covid19InfoPerPerson Covid19 { get; set; }
        public virtual VaccinesTypes VaccineTypeNavigation { get; set; }
    }
}
