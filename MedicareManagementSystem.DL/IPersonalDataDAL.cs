using MedicareManagementSystem.DAL.Models;
using System.Collections.Generic;

namespace MedicareManagementSystem.DAL
{
    public interface IPersonalDataDAL
    {
        bool AddPersonalData(PersonalData newPerson);
        bool DeletePersonalData(string id);
        List<PersonalData> GetAllPersonalData();
        bool UpdatePersonalData( PersonalData personalData);
    }
}