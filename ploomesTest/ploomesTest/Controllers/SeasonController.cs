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
    public class SeasonController : ControllerBase
    {
        private readonly ISeasonApplication _seasonApplication;

        public SeasonController(ISeasonApplication seasonApplication)
        {
            _seasonApplication = seasonApplication;
        }

        [HttpGet("ListAllSeason")]
        [Produces("application/json")]

        public IActionResult ListAllSeason()
        {
            vmResult result = new vmResult();

            try
            {
                var lstSeason = _seasonApplication.ListAllSeason();

                if (lstSeason == null || lstSeason.Count() <= 0)
                {
                    result.friendlyErrorMessage = "Não foi encontrado nenhum registro";
                    return NotFound(result);
                }

                result.data = lstSeason;
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.friendlyErrorMessage = "Houve um erro";
                result.stackTrace = ex.Message + "/n" + ex.StackTrace;
                return BadRequest(result);
            }
        }

        [HttpGet("ListSeasonByAnimeId")]
        [Produces("application/json")]
        public IActionResult ListSeasonByAnimeId(int animeId)
        {
            vmResult result = new vmResult();

            try
            {
                var lstSeason = _seasonApplication.ListSeasonByAnimeId(animeId);

                if (lstSeason == null || lstSeason.Count() <= 0)
                {
                    result.friendlyErrorMessage = $"Não foi encontrado nenhum registro com este id {animeId}";
                    return NotFound(result);
                }

                result.data = lstSeason;
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.friendlyErrorMessage = "Houve um erro";
                result.stackTrace = ex.Message + "/n" + ex.StackTrace;
                return BadRequest(result);
            }
        }

        [HttpPost("InsertSeason")]
        [Produces("application/json")]
        public IActionResult InsertSeason(vmSeason vmSeason)
        {
            vmResult result = new vmResult();

            try
            {
                if (!_seasonApplication.InsertSeason(vmSeason))
                {
                    result.friendlyErrorMessage = "Não foi possível inserir este registro";
                    return BadRequest(result);
                }

                result.data = vmSeason;
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

        [HttpPut("UpdateSeason")]
        [Produces("application/json")]
        public IActionResult UpdateSeason(vmSeason vmSeason)
        {
            vmResult result = new vmResult();

            try
            {
                if (!_seasonApplication.UpdateSeason(vmSeason))
                {
                    result.friendlyErrorMessage = "Não foi possível atualizar este registro";
                    return BadRequest(result);
                }

                result.data = vmSeason;
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
