using System;
using System.Collections.Generic;

namespace MedicareManagementSystem.DAL.Models
{
    public partial class PersonalData
    {
        public PersonalData()
        {
            Covid19InfoPerPerson = new HashSet<Covid19InfoPerPerson>();
        }

        public string Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string CellPhoneNumber { get; set; }

        public virtual ICollection<Covid19InfoPerPerson> Covid19InfoPerPerson { get; set; }
    }
}
