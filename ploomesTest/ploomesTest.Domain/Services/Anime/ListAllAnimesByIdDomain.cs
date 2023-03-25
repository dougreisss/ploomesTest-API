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
    public class ListAllAnimesByIdDomain : IListAllAnimesByIdDomain
    {
        private readonly IAnimeRepository _animeRepository;

        public ListAllAnimesByIdDomain(IAnimeRepository animeRepository)
        {
            _animeRepository = animeRepository;
        }
        public AllAnimesDomain ListAllAnimesById(int animeId, int episodeId)
        {
            return _animeRepository.ListAllAnimesById(animeId, episodeId);
        }
    }
}
