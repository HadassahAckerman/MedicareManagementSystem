using MedicareManagementSystem.BLL;
using MedicareManagementSystem.DAL.Models;
using MedicareManagementSystem.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MedicareManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccinesTypesController : ControllerBase
    
    {

        IVaccinesTypesBLL _vaccinesTypesBLL;
        public VaccinesTypesController(IVaccinesTypesBLL vaccinesTypes)
        {
            _vaccinesTypesBLL = vaccinesTypes;

        }

        [HttpGet]
        [Route("GetAllVaccinesTypes")]
        public IActionResult GetAllVaccinesTypes()
        {
            try
            {
                return Ok(_vaccinesTypesBLL.GetAllVaccinesTypes());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Route("AddVaccineType")]
        public bool AddVaccineType([FromBody] VaccinesTypesDTO vaccine)
        {
            try
            {
                return _vaccinesTypesBLL.AddVaccineType(vaccine);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [HttpPut]
        [Route("UpdateVaccineType/{type}")]
        public bool UpdateVaccineType(int type, [FromBody] VaccinesTypesDTO vacType)
        {
            try
            {
                return _vaccinesTypesBLL.UpdateVaccineType(type, vacType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpDelete]
        [Route("DeleteVaccineType/{type}")]
        public bool DeleteVaccineType(int type)
        {
            try
            {
                return _vaccinesTypesBLL.DeleteVaccineType(type);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}


