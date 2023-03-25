using ploomesTest.Domain.Interfaces.Repository.Season;
using ploomesTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Services.Season
{
    public class InsertSeasonDomain : IInsertSeasonDomain
    {
        private readonly ISeasonRepository _seasonRepository;

        public InsertSeasonDomain(ISeasonRepository seasonRepository)
        {
            _seasonRepository = seasonRepository;
        }
        public bool InsertSeason(SeasonDomain seasonDomain)
        {
            return _seasonRepository.InsertSeason(seasonDomain);
        }
    }
}
