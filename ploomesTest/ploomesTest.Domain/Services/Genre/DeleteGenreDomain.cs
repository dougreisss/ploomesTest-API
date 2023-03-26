using ploomesTest.Domain.Interfaces.Command.Genre;
using ploomesTest.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Services.Genre
{
    public class DeleteGenreDomain : IDeleteGenreDomain
    {
        private readonly IGenreRepository _genreRepository;

        public DeleteGenreDomain(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public bool DeleteGenre(int genreId)
        {
            return _genreRepository.DeleteGenre(genreId);
        }
    }
}
