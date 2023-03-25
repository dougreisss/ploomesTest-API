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
    public class ListAllAnimesDomain : IListAllAnimesDomain
    {
        private readonly IAnimeRepository _animeRepository;

        public ListAllAnimesDomain(IAnimeRepository animeRepository)
        {
            _animeRepository = animeRepository;
        }

        public List<AllAnimesDomain> ListAllAnimes()
        {
            return _animeRepository.ListAllAnimes();
        }
    }
}
