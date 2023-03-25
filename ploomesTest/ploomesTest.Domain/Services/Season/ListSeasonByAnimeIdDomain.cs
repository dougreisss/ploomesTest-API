using ploomesTest.Domain.Interfaces.Command.Season;
using ploomesTest.Domain.Interfaces.Repository.Season;
using ploomesTest.Domain.Models;
using System.Collections.Generic;

namespace ploomesTest.Domain.Services.Season
{
    public class ListSeasonByAnimeIdDomain : IListSeasonByAnimeIdDomain
    {
        private readonly ISeasonRepository _seasonRepository;
        public ListSeasonByAnimeIdDomain(ISeasonRepository seasonRepository)
        {
            _seasonRepository = seasonRepository;
        }

        public List<SeasonDomain> ListSeasonByAnimeId(int animeId)
        {
            return _seasonRepository.ListSeasonByAnimeId(animeId);
        }
    }
}
