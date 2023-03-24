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
    public class UpdateGenreDomain : IUpdateGenreDomain
    {
        private readonly IGenreRepository _genreRepository;
        public UpdateGenreDomain(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }
        public bool UpdateGenre(GenreDomain genreDomain)
        {
            return _genreRepository.UpdateGenre(genreDomain);
        }
    }
}
