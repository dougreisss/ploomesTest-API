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
        private readonly IDeleteSeasonDomain _deleteSeasonDomain;

        public SeasonApplication(
            IListSeasonByAnimeIdDomain listSeasonByAnimeIdDomain,
            IInsertSeasonDomain insertSeasonDomain,
            IUpdateSeasonDomain updateSeasonDomain,
            IListAllSeasonDomain listAllSeasonDomain,
            IDeleteSeasonDomain deleteSeasonDomain
        )
        {
            _listSeasonByAnimeIdDomain = listSeasonByAnimeIdDomain;
            _insertSeasonDomain = insertSeasonDomain;
            _updateSeasonDomain = updateSeasonDomain;
            _listAllSeasonDomain = listAllSeasonDomain;
            _deleteSeasonDomain = deleteSeasonDomain;
        }

        public bool DeleteSeason(int seasonId)
        {
            return _deleteSeasonDomain.DeleteSeason(seasonId);
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
