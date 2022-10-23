using MedicareManagementSystem.DTO;
using System.Collections.Generic;

namespace MedicareManagementSystem.BLL
{
    public interface IVaccinesTypesBLL
    {
        bool AddVaccineType(VaccinesTypesDTO newVaccine);
        bool DeleteVaccineType(int type);
        List<VaccinesTypesDTO> GetAllVaccinesTypes();
        bool UpdateVaccineType(int type, VaccinesTypesDTO vac);
    }
}