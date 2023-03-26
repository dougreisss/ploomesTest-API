using ploomesTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Interfaces.Repository.Season
{
    public interface ISeasonRepository
    {
        public List<SeasonDomain> ListSeasonByAnimeId(int animeId);
        public List<SeasonDomain> ListAllSeason();
        public bool InsertSeason(SeasonDomain seasonDomain);
        public bool UpdateSeason(SeasonDomain seasonDomain);
        public bool DeleteSeason(int seasonId);
    }
}
