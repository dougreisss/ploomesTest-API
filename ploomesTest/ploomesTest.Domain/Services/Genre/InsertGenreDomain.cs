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
    public class InsertGenreDomain : IInsertGenreDomain
    {
        private readonly IGenreRepository _genreRepository;
        public InsertGenreDomain(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public bool InsertGenre(GenreDomain genreDomain)
        {
            return _genreRepository.InsertGenre(genreDomain);
        }
    }
}
