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
    public class ListAllGenreDomain : IListAllGenreDomain
    {
        private readonly IGenreRepository _genreRepository;

        public ListAllGenreDomain(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }
        public List<GenreDomain> ListAllGenre()
        {
            return _genreRepository.ListAllGenre();
        }
    }
}
