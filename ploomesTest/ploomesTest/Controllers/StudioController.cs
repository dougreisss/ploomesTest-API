using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ploomesTest.Application.Interfaces;
using ploomesTest.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ploomesTest.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudioController : ControllerBase
    {
        private readonly IStudioApplication _studioApplication;
        public StudioController(IStudioApplication studioApplication)
        {
            _studioApplication = studioApplication;
        }

        [HttpGet("ListAllStudio")]
        [Produces("application/json")]
        public IActionResult ListAllStudio()
        {
            vmResult result = new vmResult();

            try
            {
                var lstStudio = _studioApplication.ListAllStudio();

                if (lstStudio == null || lstStudio.Count() < 0)
                {
                    result.friendlyErrorMessage = $"Não foi encontrado nenhum registro!";
                    return NotFound(result);
                }

                result.data = lstStudio;
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.friendlyErrorMessage = "Houve um erro";
                result.stackTrace = ex.Message + "/n" + ex.StackTrace;
                return BadRequest(result); 
            }
        }

        [HttpPost("InsertStudio")]
        [Produces("application/json")]
        public IActionResult InsertStudio(vmStudio vmStudio)
        {
            vmResult result = new vmResult();

            try
            {
                if (!_studioApplication.InsertStudio(vmStudio))
                {
                    result.friendlyErrorMessage = "Não foi possível inserir este registro";
                    return BadRequest(result);
                }

                result.data = vmStudio;
                result.message = "Registro inserido com sucesso!";
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.friendlyErrorMessage = "Houve um erro";
                result.stackTrace = ex.Message + "/n" + ex.StackTrace;
                return BadRequest(result);
            }

        }

        [HttpPut("UpdateStudio")]
        [Produces("application/json")]
        public IActionResult UpdateStudio(vmStudio vmStudio)
        {
            vmResult result = new vmResult();

            try
            {
                if (!_studioApplication.UpdateStudio(vmStudio))
                {
                    result.friendlyErrorMessage = "Não foi possível inserir este registro";
                    return BadRequest(result);
                }

                result.data = vmStudio;
                result.message = "Registro atualizado com sucesso!";
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.friendlyErrorMessage = "Houve um erro";
                result.stackTrace = ex.Message + "/n" + ex.StackTrace;
                return BadRequest(result);
            }
        }
    }
}
