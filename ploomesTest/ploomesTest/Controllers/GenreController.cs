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
    public class GenreController : ControllerBase
    {
        private readonly IGenreApplication _genreApplication;
        public GenreController(IGenreApplication genreApplication)
        {
            _genreApplication = genreApplication;
        }

        [HttpGet("ListGenreByAnimeId")]
        [Produces("application/json")]
        public IActionResult ListGenreByAnimeId(int animeId)
        {
            vmResult result = new vmResult();

            try
            {
                var lstGenreByAnimeId = _genreApplication.ListGenreByAnimeId(animeId);

                if (lstGenreByAnimeId == null || lstGenreByAnimeId.Count() <= 0)
                {
                    result.friendlyErrorMessage = $"Não foi encontrado nenhum registro com este id ({animeId})";
                    return NotFound(result);
                }

                result.data = lstGenreByAnimeId;

                return Ok(result);
            }
            catch (Exception ex)
            {
                result.friendlyErrorMessage = "Houve um erro";
                result.stackTrace = ex.Message + "/n" + ex.StackTrace;
                return BadRequest(result);
            }
        }

        [HttpGet("ListAllGenre")]
        [Produces("application/json")]
        public IActionResult ListAllGenre()
        {
            vmResult result = new vmResult();

            try
            {
                var lstAllGenre = _genreApplication.ListAllGenre();

                if (lstAllGenre == null || lstAllGenre.Count() <= 0)
                {
                    result.friendlyErrorMessage = $"Não foi encontrado nenhum registro";
                    return NotFound(result);
                }

                result.data = lstAllGenre;

                return Ok(result);

            }
            catch (Exception ex)
            {
                result.friendlyErrorMessage = "Houve um erro";
                result.stackTrace = ex.Message + "/n" + ex.StackTrace;
                return BadRequest(result);
            }
        }

        [HttpPost("UpdateGenre")]
        [Produces("application/json")]
        public IActionResult UpdateGenre(vmGenre vmGenre)
        {
            vmResult result = new vmResult();

            try
            {
                if (!_genreApplication.UpdateGenre(vmGenre))
                {
                    result.friendlyErrorMessage = "Não foi possível atualizar este registro";
                    return BadRequest(result);
                }

                result.data = vmGenre;
                result.friendlyErrorMessage = "Registro atualizado com sucesso!";
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
