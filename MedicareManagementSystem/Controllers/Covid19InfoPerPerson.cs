using MedicareManagementSystem.BLL;
using MedicareManagementSystem.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MedicareManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Covid19InfoPerPersonController : ControllerBase
    {

        ICovid19InfoPerPersonBLL _covid19InfoPerPersonBLL;
            public Covid19InfoPerPersonController(ICovid19InfoPerPersonBLL covidInfo)
            {
            _covid19InfoPerPersonBLL = covidInfo;

            }

            [HttpGet]
            [Route("GetAllCovid19InfoPerPerson")]
            public IActionResult GetAllCovid19InfoPerPerson()
            {
                try
                {
                    return Ok(_covid19InfoPerPersonBLL.GetAllCovid19InfoPerPerson());
                }
                catch (Exception ex)
                {
                    return StatusCode(500, ex.Message);
                }
            }

            [HttpPost]
            [Route("AddCovid19InfoPerPerson")]
            public bool AddCovid19InfoPerPerson([FromBody] Covid19InfoPerPersonDTO vaccine)
            {
                try
                {
                    return _covid19InfoPerPersonBLL.AddCovid19InfoPerPerson(vaccine);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }



            [HttpPut]
            [Route("UpdateCovid19InfoPerPerson/{type}")]
            public bool UpdateCovid19InfoPerPerson(string code, [FromBody] Covid19InfoPerPersonDTO info)
            {
                try
                {
                    return _covid19InfoPerPersonBLL.UpdateCovid19InfoPerPerson(code, info);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            [HttpDelete]
            [Route("DeleteMemberInfo/{type}")]
            public bool DeleteMemberInfo(string code)
            {
                try
                {
                    return _covid19InfoPerPersonBLL.DeleteMemberInfo(code);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }
    }


