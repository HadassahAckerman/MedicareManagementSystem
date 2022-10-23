using AutoMapper;
using MedicareManagementSystem.DAL;
using MedicareManagementSystem.DAL.Models;
using MedicareManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicareManagementSystem.BLL
{
    public class Covid19InfoPerPersonBLL : ICovid19InfoPerPersonBLL
    {
        ICovid19InfoPerPersonDAL _Covid19InfoPerPersonDAL;

        IMapper mapper;

        public Covid19InfoPerPersonBLL(ICovid19InfoPerPersonDAL newInfo)
        {
            _Covid19InfoPerPersonDAL = newInfo;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }


        public List<Covid19InfoPerPersonDTO> GetAllCovid19InfoPerPerson()
        {
            List<Covid19InfoPerPerson> allInfo = _Covid19InfoPerPersonDAL.GetAllCovid19InfoPerPerson();
            return mapper.Map<List<Covid19InfoPerPerson>, List<Covid19InfoPerPersonDTO>>(allInfo);
        }

        public bool AddCovid19InfoPerPerson(Covid19InfoPerPersonDTO newInfo)
        {
            Covid19InfoPerPerson info = mapper.Map<Covid19InfoPerPersonDTO, Covid19InfoPerPerson>(newInfo);
            return _Covid19InfoPerPersonDAL.AddCovid19InfoPerPerson(info);
        }
        public bool UpdateCovid19InfoPerPerson(string code, Covid19InfoPerPersonDTO vac)
        {
            Covid19InfoPerPerson newVac = mapper.Map<Covid19InfoPerPersonDTO, Covid19InfoPerPerson>(vac);
            return _Covid19InfoPerPersonDAL.UpdateCovid19InfoPerPerson(code, newVac);
        }

        public bool DeleteMemberInfo(string code)
        {
            return _Covid19InfoPerPersonDAL.DeleteMemberInfo(code);
        }



    }
}

  
