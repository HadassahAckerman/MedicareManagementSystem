using MedicareManagementSystem.DTO;
using System.Collections.Generic;

namespace MedicareManagementSystem.BLL
{
    public interface IPersonalDataBLL
    {
        bool AddPersonalData(PersonalDataDTO newPersonData);
        bool DeletePersonalData(string id);
        List<PersonalDataDTO> GetAllPersonalData();
        bool UpdatePersonalData( PersonalDataDTO newData);
    }
}