using AutoMapper;
using MedicareManagementSystem.DAL;
using MedicareManagementSystem.DAL.Models;
using MedicareManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicareManagementSystem.BLL
{
    public class PersonalDataBLL : IPersonalDataBLL
    {

        IPersonalDataDAL _personalDataDAL;

        IMapper mapper;

        public PersonalDataBLL(IPersonalDataDAL personalDataDAL)
        {
            _personalDataDAL = personalDataDAL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }


        public List<PersonalDataDTO> GetAllPersonalData()
        {
            List<PersonalData> allData = _personalDataDAL.GetAllPersonalData();
            return mapper.Map<List<PersonalData>, List<PersonalDataDTO>>(allData);
        }

        public bool AddPersonalData(PersonalDataDTO newPersonData)
        {
            PersonalData newPerson = mapper.Map<PersonalDataDTO, PersonalData>(newPersonData);
            return _personalDataDAL.AddPersonalData(newPerson);
        }
        public bool UpdatePersonalData( PersonalDataDTO newData)
        {

            PersonalData newPersonalData = mapper.Map<PersonalDataDTO, PersonalData>(newData);
            return _personalDataDAL.UpdatePersonalData(newPersonalData);
        }
        public bool DeletePersonalData(string id)
        {
            return _personalDataDAL.DeletePersonalData(id);
        }



    }
}
