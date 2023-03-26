using ploomesTest.Domain.Interfaces.Command.Anime;
using ploomesTest.Domain.Interfaces.Repository.Anime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Services.Anime
{
    public class InsertAnimeGenreDomain : IInsertAnimeGenreDomain
    {
        private readonly IAnimeRepository _animeRepository;

        public InsertAnimeGenreDomain(IAnimeRepository animeRepository)
        {
            _animeRepository = animeRepository;
        }
        public bool InsertAnimeGenre(int animeId, int genreId)
        {
            return _animeRepository.InsertAnimeGenre(animeId, genreId);
        }
    }
}
