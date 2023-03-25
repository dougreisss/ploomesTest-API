using ploomesTest.Domain.Models;
using System.Collections.Generic;

namespace ploomesTest.Domain.Interfaces.Command.Season
{
    public interface IListSeasonByAnimeIdDomain
    {
        public List<SeasonDomain> ListSeasonByAnimeId(int animeId);
    }
}
