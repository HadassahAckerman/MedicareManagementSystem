using MedicareManagementSystem.DAL.Models;
using System.Collections.Generic;

namespace MedicareManagementSystem.DAL
{
    public interface IVaccinesPerPersonDAL
    {
        bool AddMemberVaccine(VaccinesPerPerson newPerVaccine);
        bool DeleteMemberVaccine(string covidId);
        List<VaccinesPerPerson> GetAllMemberVaccine();
        bool UpdateMemberVaccine(string covidId, VaccinesPerPerson newVaccine);
    }
}