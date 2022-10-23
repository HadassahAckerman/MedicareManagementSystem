using MedicareManagementSystem.DAL.Models;
using System.Collections.Generic;

namespace MedicareManagementSystem.DAL
{
    public interface IVaccinesTypesDAL
    {
        bool AddVaccineType(VaccinesTypes newVaccine);
        bool DeleteVaccineType(int type);
        List<VaccinesTypes> GetAllVaccinesTypes();
        bool UpdateVaccineType(int type, VaccinesTypes vaccineType);
    }
}