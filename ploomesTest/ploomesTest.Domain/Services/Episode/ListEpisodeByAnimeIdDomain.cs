using ploomesTest.Domain.Interfaces.Command.Episode;
using ploomesTest.Domain.Interfaces.Repository.Episode;
using ploomesTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Services.Episode
{
    public class ListEpisodeByAnimeIdDomain : IListEpisodeByAnimeIdDomain
    {
        private readonly IEpisodeRepository _episodeRepository;

        public ListEpisodeByAnimeIdDomain(IEpisodeRepository episodeRepository)
        {
            _episodeRepository = episodeRepository;
        }
        public List<EpisodeDomain> ListEpisodeByAnimeId(int animeId)
        {
            return _episodeRepository.ListEpisodeByAnimeId(animeId);
        }
    }
}
