using MedicareManagementSystem.BLL;
using MedicareManagementSystem.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Net.Http;


namespace MedicareManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalDataController : ControllerBase
    {


        IPersonalDataBLL _personalDataBLL;
            public PersonalDataController(IPersonalDataBLL personalDataBLL)
            {
                _personalDataBLL = personalDataBLL;

        }

        [HttpGet]
            [Route("GetAllPersonalData")]
            public IActionResult GetAllPersonalData()
            {
                try
                {
                    return Ok(_personalDataBLL.GetAllPersonalData());
                }
                catch (Exception ex)
                {
                    return StatusCode(500, ex.Message);
                }
            }

            [HttpPost]
            [Route("AddPersonalData")]
            public bool AddPersonalData([FromBody] PersonalDataDTO person)
            {
                try
                {
                    return _personalDataBLL.AddPersonalData(person);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            [HttpPut]
            [Route("UpdatePersonalData")]
            public bool UpdatePersonalData( [FromBody] PersonalDataDTO personalData)
            {
                try
                {
                    return _personalDataBLL.UpdatePersonalData(personalData);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            [HttpDelete]
            [Route("DeletePersonalData/{id}")]
            public bool DeletePersonalData(string id)
            {
                try
                {
                    return _personalDataBLL.DeletePersonalData(id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        
    }
}

