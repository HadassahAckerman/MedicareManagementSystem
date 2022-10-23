using MedicareManagementSystem.DTO;
using System.Collections.Generic;

namespace MedicareManagementSystem.BLL
{
    public interface ICovid19InfoPerPersonBLL
    {
        bool AddCovid19InfoPerPerson(Covid19InfoPerPersonDTO newInfo);
        bool DeleteMemberInfo(string code);
        List<Covid19InfoPerPersonDTO> GetAllCovid19InfoPerPerson();
        bool UpdateCovid19InfoPerPerson(string code, Covid19InfoPerPersonDTO vac);
    }
}