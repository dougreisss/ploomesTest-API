using ploomesTest.Domain.Interfaces.Repository.Season;
using ploomesTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Services.Season
{
    public class ListAllSeasonDomain : IListAllSeasonDomain
    {
        private readonly ISeasonRepository _seasonRepository;

        public ListAllSeasonDomain(ISeasonRepository seasonRepository)
        {
            _seasonRepository = seasonRepository;
        }
        public List<SeasonDomain> ListAllSeason()
        {
            return _seasonRepository.ListAllSeason();
        }
    }
}
