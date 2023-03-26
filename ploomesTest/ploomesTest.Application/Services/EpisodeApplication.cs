using ploomesTest.Application.Interfaces;
using ploomesTest.Application.ViewModels;
using ploomesTest.Domain.Interfaces.Command.Episode;
using ploomesTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Application.Services
{
    public class EpisodeApplication : ApplicationBase, IEpisodeApplication
    {
        private readonly IListEpisodeByAnimeIdDomain _listEpisodeByAnimeIdDomain;
        private readonly IInsertEpisodeDomain _insertEpisodeDomain;
        private readonly IUpdateEpisodeDomain _updateEpisodeDomain;
        private readonly IDeleteEpisodeDomain _deleteEpisodeDomain;

        public EpisodeApplication(
            IListEpisodeByAnimeIdDomain listEpisodeByAnimeIdDomain,
            IInsertEpisodeDomain insertEpisodeDomain,
            IUpdateEpisodeDomain updateEpisodeDomain,
            IDeleteEpisodeDomain deleteEpisodeDomain
        ) 
        {
            _listEpisodeByAnimeIdDomain = listEpisodeByAnimeIdDomain;
            _insertEpisodeDomain = insertEpisodeDomain;
            _updateEpisodeDomain = updateEpisodeDomain;
            _deleteEpisodeDomain = deleteEpisodeDomain;
        }

        public bool DeleteEpisode(int episodeId, int animeId)
        {
            return _deleteEpisodeDomain.DeleteEpisode(episodeId, animeId);
        }

        public bool InsertEpisode(vmInsertEpisode episode)
        {
            return _insertEpisodeDomain.InsertEpisode(Read<EpisodeDomain>(episode));
        }

        public List<vmEpisode> ListEpisodeByAnimeId(int animeId)
        {
            return List<vmEpisode>(_listEpisodeByAnimeIdDomain.ListEpisodeByAnimeId(animeId));
        }

        public bool UpdateEpisode(vmEpisode episode)
        {
            return _updateEpisodeDomain.UpdateEpisode(Read<EpisodeDomain>(episode));
        }
    }
}
