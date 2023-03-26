using ploomesTest.Application.Interfaces;
using ploomesTest.Application.ViewModels;
using ploomesTest.Domain.Interfaces.Command;
using ploomesTest.Domain.Interfaces.Command.Genre;
using ploomesTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Application.Services
{
    public class GenreApplication : ApplicationBase, IGenreApplication
    {
        private readonly IListGenreByAnimeIdDomain _listGenreByAnimeIdDomain;
        private readonly IListAllGenreDomain _listAllGenreDomain;
        private readonly IUpdateGenreDomain _updateGenreDomain;
        private readonly IInsertGenreDomain _insertGenreDomain;
        private readonly IDeleteGenreDomain _deleteGenreDomain;

        public GenreApplication(
            IListGenreByAnimeIdDomain listGenreByAnimeId, 
            IListAllGenreDomain listAllGenreDomain,
            IUpdateGenreDomain updateGenreDomain,
            IInsertGenreDomain insertGenreDomain,
            IDeleteGenreDomain deleteGenreDomain
        )
        {
            _listGenreByAnimeIdDomain = listGenreByAnimeId;
            _listAllGenreDomain = listAllGenreDomain;
            _updateGenreDomain = updateGenreDomain;
            _insertGenreDomain = insertGenreDomain;
            _deleteGenreDomain = deleteGenreDomain;
        }

        public bool DeleteGenre(int genreId)
        {
            return _deleteGenreDomain.DeleteGenre(genreId);
        }

        public bool InsertGenre(vmInsertGenre vmGenre)
        {
            return _insertGenreDomain.InsertGenre(Read<GenreDomain>(vmGenre));
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

        public bool UpdateGenre(vmGenre vmGenre)
        {
            return _updateGenreDomain.UpdateGenre(Read<GenreDomain>(vmGenre));
        }
    }
}
