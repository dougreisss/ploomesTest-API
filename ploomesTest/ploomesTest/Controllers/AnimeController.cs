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
    public class AnimeController : ControllerBase
    {
        private readonly IAnimeApplication _animeApplication;
        public AnimeController(IAnimeApplication animeApplication)
        {
            _animeApplication = animeApplication;
        }

        [HttpGet("ListAllAnimes")]
        [Produces("application/json")]
        public IActionResult ListAllAnimes()
        {
            vmResult result = new vmResult();

            try
            {
                var lstAllAnimes = _animeApplication.ListAllAnimes();

                if (lstAllAnimes == null || lstAllAnimes.Count() <= 0)
                {
                    result.friendlyErrorMessage = $"Não foi encontrado nenhum registro";
                    return NotFound(result);
                }

                result.data = lstAllAnimes;
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
