using ploomesTest.Domain.Interfaces.Repository.Season;
using ploomesTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Services.Season
{
    public class UpdateSeasonDomain : IUpdateSeasonDomain
    {
        private readonly ISeasonRepository _seasonRepository;

        public UpdateSeasonDomain(ISeasonRepository seasonRepository)
        {
            _seasonRepository = seasonRepository;
        }
        public bool UpdateSeason(SeasonDomain seasonDomain)
        {
            return _seasonRepository.UpdateSeason(seasonDomain);
        }
    }
}
