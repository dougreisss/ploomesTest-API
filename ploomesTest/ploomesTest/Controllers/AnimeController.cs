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
                    result.friendlyErrorMessage = "Não foi encontrado nenhum registro";
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

        [HttpGet("ListAllAnimesById")]
        [Produces("application/json")]
        public IActionResult ListByAnimeIdAndEpisodeId(int animeId, int episodeId)
        {
            vmResult result = new vmResult();

            try
            {
                var lstAllAnime = _animeApplication.ListAllAnimesById(animeId, episodeId);

                if (lstAllAnime == null)
                {
                    result.friendlyErrorMessage = $"Não foi encontrado nenhum registro";
                    return NotFound(result);
                }

                result.data = lstAllAnime;

                return Ok(result);

            }
            catch (Exception ex)
            {
                result.friendlyErrorMessage = "Houve um erro";
                result.stackTrace = ex.Message + "/n" + ex.StackTrace;
                return BadRequest(result);
            }
        }

        [HttpPost("InsertAnime")]
        [Produces("application/json")]
        public IActionResult InsertAnime(vmAnime vmAnime)
        {
            vmResult result = new vmResult();

            try
            {
                if (!_animeApplication.InsertAnime(vmAnime))
                {
                    result.friendlyErrorMessage = "Não foi possível inserir este registro";
                    return BadRequest(result);
                }

                result.data = vmAnime;
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


        [HttpPost("InsertAnimeGenre")]
        [Produces("application/json")]
        public IActionResult InsertAnimeGenre(int animeId, int genreId)
        {
            vmResult result = new vmResult();

            try
            {
                if (!_animeApplication.InsertAnimeGenre(animeId, genreId))
                {
                    result.friendlyErrorMessage = "Não foi possivel inserir este registro!";
                    return BadRequest(result);
                }

                result.message = "Registro inserido com sucesso!";
                return Created("teste", result);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut("UpdateAnime")]
        [Produces("application/json")]
        public IActionResult UpdateAnime(vmAnime vmAnime)
        {
            vmResult result = new vmResult();

            try
            {
                if (!_animeApplication.UpdateAnime(vmAnime))
                {
                    result.friendlyErrorMessage = "Não foi possível atualizar este registro";
                    return BadRequest(result);
                }

                result.data = vmAnime;
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

        [HttpDelete("DeleteAnime")]
        [Produces("application/json")]
        public IActionResult DeleteAnime(int animeId)
        {
            vmResult result = new vmResult();

            try
            {
                if (!_animeApplication.DeleteAnime(animeId))
                {
                    result.friendlyErrorMessage = "Não foi possível atualizar este registro";
                    return BadRequest(result);
                }

                result.message = "Registro deletado com sucesso!";
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
