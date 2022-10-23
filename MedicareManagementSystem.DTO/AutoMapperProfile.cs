using MedicareManagementSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicareManagementSystem.DTO
{
    public class AutoMapperProfile : AutoMapper.Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<PersonalDataDTO, PersonalData>();
            CreateMap<PersonalData, PersonalDataDTO>();

            CreateMap<VaccinesTypesDTO, VaccinesTypes>();
            CreateMap<VaccinesTypes, VaccinesTypesDTO>();

            CreateMap<VaccinesPerPersonDTO, VaccinesPerPerson>();
            CreateMap<VaccinesPerPerson, VaccinesPerPersonDTO>();

            CreateMap<Covid19InfoPerPersonDTO, Covid19InfoPerPerson>();
            CreateMap<Covid19InfoPerPerson, Covid19InfoPerPersonDTO>();


        }
    }
}
