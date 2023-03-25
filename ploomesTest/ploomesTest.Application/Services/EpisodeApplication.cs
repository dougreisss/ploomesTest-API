using ploomesTest.Application.Interfaces;
using ploomesTest.Application.ViewModels;
using ploomesTest.Domain.Interfaces.Command.Episode;
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
        public EpisodeApplication(IListEpisodeByAnimeIdDomain listEpisodeByAnimeIdDomain) 
        {
            _listEpisodeByAnimeIdDomain = listEpisodeByAnimeIdDomain;
        }

        public List<vmEpisode> ListEpisodeByAnimeId(int animeId)
        {
            return List<vmEpisode>(_listEpisodeByAnimeIdDomain.ListEpisodeByAnimeId(animeId));
        }
    }
}
