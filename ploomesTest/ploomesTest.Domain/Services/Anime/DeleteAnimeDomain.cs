using ploomesTest.Domain.Interfaces.Command.Anime;
using ploomesTest.Domain.Interfaces.Repository.Anime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Services.Anime
{
    public class DeleteAnimeDomain : IDeleteAnimeDomain
    {
        private readonly IAnimeRepository _animeRepository;

        public DeleteAnimeDomain(IAnimeRepository animeRepository)
        {
            _animeRepository = animeRepository;
        }

        public bool DeleteAnime(int animeId)
        {
            return _animeRepository.DeleteAnime(animeId);
        }
    }
}
