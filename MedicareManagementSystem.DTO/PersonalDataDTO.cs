using MedicareManagementSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicareManagementSystem.DTO
{
    public class PersonalDataDTO
    {
        public string Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string CellPhoneNumber { get; set; }

    }
}
