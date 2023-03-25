using ploomesTest.Domain.Interfaces.Command.Anime;
using ploomesTest.Domain.Interfaces.Repository.Anime;
using ploomesTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Services.Anime
{
    public class UpdateAnimeDomain : IUpdateAnimeDomain
    {
        private readonly IAnimeRepository _animeRepository;

        public UpdateAnimeDomain(IAnimeRepository animeRepository)
        {
            _animeRepository = animeRepository;
        }
        public bool UpdateAnime(AnimeDomain animeDomain)
        {
            return _animeRepository.UpdateAnime(animeDomain);
        }
    }
}
