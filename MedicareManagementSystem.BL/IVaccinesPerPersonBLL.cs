using MedicareManagementSystem.DTO;
using System.Collections.Generic;

namespace MedicareManagementSystem.BLL
{
    public interface IVaccinesPerPersonBLL
    {
        bool AddMemberVaccine(VaccinesPerPersonDTO newVaccine);
        bool DeleteMemberVaccine(string code);
        List<VaccinesPerPersonDTO> GetAllMemberVaccine();
        bool UpdateMemberVaccine(string code, VaccinesPerPersonDTO vac);
    }
}