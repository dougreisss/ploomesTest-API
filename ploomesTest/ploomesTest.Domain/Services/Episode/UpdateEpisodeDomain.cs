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
    public class UpdateEpisodeDomain : IUpdateEpisodeDomain
    {
        private readonly IEpisodeRepository _episodeRepository;

        public UpdateEpisodeDomain(IEpisodeRepository episodeRepository)
        {
            _episodeRepository = episodeRepository;
        }

        public bool UpdateEpisode(EpisodeDomain episodeDomain)
        {
            return _episodeRepository.UpdateEpisode(episodeDomain);
        }
    }
}
