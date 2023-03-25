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
    public class EpisodeController : ControllerBase
    {
        private readonly IEpisodeApplication _episodeApplication;
        public EpisodeController(IEpisodeApplication episodeApplication)
        {
            _episodeApplication = episodeApplication;
        }

        [HttpGet("ListEpisodeByAnimeId")]
        [Produces("application/json")]
        public IActionResult ListEpisodeByAnimeId(int animeId)
        {
            vmResult result = new vmResult();

            try
            {
                var lstEpisode = _episodeApplication.ListEpisodeByAnimeId(animeId);

                if (lstEpisode == null || lstEpisode.Count() < 0)
                {
                    result.friendlyErrorMessage = $"Não foi encontrado nenhum registro com este id ({animeId})";
                    return NotFound(result);
                }

                result.data = lstEpisode;
                return Ok(result);

            }
            catch (Exception ex)
            {
                result.friendlyErrorMessage = "Houve um erro";
                result.stackTrace = ex.Message + "/n" + ex.StackTrace;
                return BadRequest(result);
            }
        }

        [HttpPost("InsertEpisode")]
        [Produces("application/json")]
        public IActionResult InsertEpisode(vmEpisode episode)
        {
            vmResult result = new vmResult();

            try
            {
                if (!_episodeApplication.InsertEpisode(episode))
                {
                    result.friendlyErrorMessage = "Não foi possível inserir este registro";
                    return BadRequest(result);
                }


                result.data = episode;
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

        [HttpPut("UpdateEpisode")]
        [Produces("application/json")]
        public IActionResult UpdateEpisode(vmEpisode vmEpisode)
        {
            vmResult result = new vmResult();

            try
            {
                if (!_episodeApplication.UpdateEpisode(vmEpisode))
                {
                    result.friendlyErrorMessage = "Não foi possível atualizar este registro";
                    return BadRequest(result);
                }

                result.data = vmEpisode;
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
