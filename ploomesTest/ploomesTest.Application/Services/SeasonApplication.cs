using ploomesTest.Application.Interfaces;
using ploomesTest.Application.ViewModels;
using ploomesTest.Domain.Interfaces.Command.Season;
using ploomesTest.Domain.Interfaces.Repository.Season;
using ploomesTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Application.Services
{
    public class SeasonApplication : ApplicationBase, ISeasonApplication
    {
        private readonly IListSeasonByAnimeIdDomain _listSeasonByAnimeIdDomain;
        private readonly IInsertSeasonDomain _insertSeasonDomain;
        private readonly IUpdateSeasonDomain _updateSeasonDomain;
        private readonly IListAllSeasonDomain _listAllSeasonDomain;

        public SeasonApplication(
            IListSeasonByAnimeIdDomain listSeasonByAnimeIdDomain,
            IInsertSeasonDomain insertSeasonDomain,
            IUpdateSeasonDomain updateSeasonDomain,
            IListAllSeasonDomain listAllSeasonDomain
        )
        {
            _listSeasonByAnimeIdDomain = listSeasonByAnimeIdDomain;
            _insertSeasonDomain = insertSeasonDomain;
            _updateSeasonDomain = updateSeasonDomain;
            _listAllSeasonDomain = listAllSeasonDomain;
        }

        public bool InsertSeason(vmSeason vmSeason)
        {
            return _insertSeasonDomain.InsertSeason(Read<SeasonDomain>(vmSeason));
        }

        public List<vmSeason> ListAllSeason()
        {
            return List<vmSeason>(_listAllSeasonDomain.ListAllSeason());
        }

        public List<vmSeason> ListSeasonByAnimeId(int animeId)
        {
            return List<vmSeason>(_listSeasonByAnimeIdDomain.ListSeasonByAnimeId(animeId));
        }

        public bool UpdateSeason(vmSeason vmSeason)
        {
            return _updateSeasonDomain.UpdateSeason(Read<SeasonDomain>(vmSeason));
        }
    }
}
