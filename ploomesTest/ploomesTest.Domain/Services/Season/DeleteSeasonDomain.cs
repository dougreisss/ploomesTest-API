using ploomesTest.Domain.Interfaces.Command.Season;
using ploomesTest.Domain.Interfaces.Repository.Season;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Services.Season
{
    public class DeleteSeasonDomain : IDeleteSeasonDomain
    {
        private readonly ISeasonRepository _seasonRepository;

        public DeleteSeasonDomain(ISeasonRepository seasonRepository)
        {
            _seasonRepository = seasonRepository;
        }
        public bool DeleteSeason(int seasonId)
        {
            return _seasonRepository.DeleteSeason(seasonId);
        }
    }
}
