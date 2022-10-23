using MedicareManagementSystem.BLL;
using MedicareManagementSystem.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MedicareManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccinesPerPersonController : ControllerBase
    {
        IVaccinesPerPersonBLL _vaccinesPerPersonBLL;
        public VaccinesPerPersonController(IVaccinesPerPersonBLL vacInfo)
        {
            _vaccinesPerPersonBLL = vacInfo;

        }

        [HttpGet]
        [Route("GetAllMemberVaccine")]
        public IActionResult GetAllMemberVaccine()
        {
            try
            {
                return Ok(_vaccinesPerPersonBLL.GetAllMemberVaccine());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Route("AddMemberVaccine")]
        public bool AddMemberVaccine([FromBody] VaccinesPerPersonDTO vaccine)
        {
            try
            {
                return _vaccinesPerPersonBLL.AddMemberVaccine(vaccine);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [HttpPut]
        [Route("UpdateMemberVaccine/{type}")]
        public bool UpdateMemberVaccine(string code, [FromBody] VaccinesPerPersonDTO info)
        {
            try
            {
                return _vaccinesPerPersonBLL.UpdateMemberVaccine(code, info);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpDelete]
        [Route("DeleteMemberVaccine/{type}")]
        public bool DeleteMemberVaccine(string code)
        {
            try
            {
                return _vaccinesPerPersonBLL.DeleteMemberVaccine(code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

   
