using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using MedicareManagementSystem.DAL;
using MedicareManagementSystem.DAL.Models;
using MedicareManagementSystem.DTO;

namespace MedicareManagementSystem.BLL
{
    public class VaccinesTypesBLL : IVaccinesTypesBLL
    {
        IVaccinesTypesDAL _vaccinesTypesDAL;

        IMapper mapper;

        public VaccinesTypesBLL(IVaccinesTypesDAL vaccinesTypesAL)
        {
            _vaccinesTypesDAL = vaccinesTypesAL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }


        public List<VaccinesTypesDTO> GetAllVaccinesTypes()
        {
            List<VaccinesTypes> allVaccines = _vaccinesTypesDAL.GetAllVaccinesTypes();
            return mapper.Map<List<VaccinesTypes>, List<VaccinesTypesDTO>>(allVaccines);
        }

        public bool AddVaccineType(VaccinesTypesDTO newVaccine)
        {
            VaccinesTypes newVac = mapper.Map<VaccinesTypesDTO, VaccinesTypes>(newVaccine);
            return _vaccinesTypesDAL.AddVaccineType(newVac);
        }
        public bool UpdateVaccineType(int type, VaccinesTypesDTO vac)
        {

            VaccinesTypes newVac = mapper.Map<VaccinesTypesDTO, VaccinesTypes>(vac);
            return _vaccinesTypesDAL.UpdateVaccineType(type, newVac);
        }
        public bool DeleteVaccineType(int type)
        {
            return _vaccinesTypesDAL.DeleteVaccineType(type);
        }



    }
}
