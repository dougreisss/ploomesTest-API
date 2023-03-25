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
    public class InsertEpisodeDomain : IInsertEpisodeDomain
    {
        private readonly IEpisodeRepository _episodeRepository;

        public InsertEpisodeDomain(IEpisodeRepository episodeRepository)
        {
            _episodeRepository = episodeRepository;
        }

        public bool InsertEpisode(EpisodeDomain episodeDomain)
        {
            return _episodeRepository.InsertEpisode(episodeDomain);
        }
    }
}
