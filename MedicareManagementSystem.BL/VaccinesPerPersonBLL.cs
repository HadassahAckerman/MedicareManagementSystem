using AutoMapper;
using MedicareManagementSystem.DAL;
using MedicareManagementSystem.DAL.Models;
using MedicareManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicareManagementSystem.BLL
{
    public class VaccinesPerPersonBLL : IVaccinesPerPersonBLL
    {
        IVaccinesPerPersonDAL _vaccinesPerPersonDAL;

        IMapper mapper;

        public VaccinesPerPersonBLL(IVaccinesPerPersonDAL vaccinesPer)
        {
            _vaccinesPerPersonDAL = vaccinesPer;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }


        public List<VaccinesPerPersonDTO> GetAllMemberVaccine()
        {
            List<VaccinesPerPerson> allVaccines = _vaccinesPerPersonDAL.GetAllMemberVaccine();
            return mapper.Map<List<VaccinesPerPerson>, List<VaccinesPerPersonDTO>>(allVaccines);
        }

        public bool AddMemberVaccine(VaccinesPerPersonDTO newVaccine)
        {
            VaccinesPerPerson newVac = mapper.Map<VaccinesPerPersonDTO, VaccinesPerPerson>(newVaccine);
            return _vaccinesPerPersonDAL.AddMemberVaccine(newVac);
        }
        public bool UpdateMemberVaccine(string code, VaccinesPerPersonDTO vac)
        {

            VaccinesPerPerson newVac = mapper.Map<VaccinesPerPersonDTO, VaccinesPerPerson>(vac);
            return _vaccinesPerPersonDAL.UpdateMemberVaccine(code, newVac);
        }
        public bool DeleteMemberVaccine(string code)
        {
            return _vaccinesPerPersonDAL.DeleteMemberVaccine(code);
        }



    }
}

  

