using ploomesTest.Domain.Interfaces.Command;
using ploomesTest.Domain.Interfaces.Repository;
using ploomesTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Services
{
    public class ListGenreByAnimeIdDomain : IListGenreByAnimeIdDomain
    {
        private readonly IGenreRepository _genreRepository;
        public ListGenreByAnimeIdDomain(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public List<GenreDomain> ListGenreByAnimeId(int animeId)
        {
            return _genreRepository.ListGenreByAnimeId(animeId);
        }
    }
}
