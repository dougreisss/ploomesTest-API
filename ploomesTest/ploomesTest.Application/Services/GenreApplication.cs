using ploomesTest.Application.Interfaces;
using ploomesTest.Application.ViewModels;
using ploomesTest.Domain.Interfaces.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Application.Services
{
    public class GenreApplication : ApplicationBase, IGenreApplication
    {
        IListGenreByAnimeIdDomain _listGenreByAnimeIdDomain;
        IListAllGenreDomain _listAllGenreDomain;
        public GenreApplication(IListGenreByAnimeIdDomain listGenreByAnimeId, IListAllGenreDomain listAllGenreDomain)
        {
            _listGenreByAnimeIdDomain = listGenreByAnimeId;
            _listAllGenreDomain = listAllGenreDomain;
        }

        public List<vmGenre> ListAllGenre()
        {
            var lstAllGenre = _listAllGenreDomain.ListAllGenre();
            return List<vmGenre>(lstAllGenre);
        }

        public List<vmGenre> ListGenreByAnimeId(int animeId)
        {
            var lstGenreByAnimeId = _listGenreByAnimeIdDomain.ListGenreByAnimeId(animeId);

            return List<vmGenre>(lstGenreByAnimeId);
        }

     
    }
}
