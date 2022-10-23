using MedicareManagementSystem.DAL.Models;
using System.Collections.Generic;

namespace MedicareManagementSystem.DAL
{
    public interface ICovid19InfoPerPersonDAL
    {
        bool AddCovid19InfoPerPerson(Covid19InfoPerPerson newCovid19PersonalData);
        bool DeleteMemberInfo(string covidId);
        List<Covid19InfoPerPerson> GetAllCovid19InfoPerPerson();
        bool UpdateCovid19InfoPerPerson(string covid19PerCode, Covid19InfoPerPerson newInfo);
    }
}