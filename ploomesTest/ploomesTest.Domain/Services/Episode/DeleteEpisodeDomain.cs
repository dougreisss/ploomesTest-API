using ploomesTest.Domain.Interfaces.Command.Episode;
using ploomesTest.Domain.Interfaces.Repository.Episode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Services.Episode
{
    public class DeleteEpisodeDomain : IDeleteEpisodeDomain
    {
        private readonly IEpisodeRepository _episodeRepository;

        public DeleteEpisodeDomain(IEpisodeRepository episodeRepository)
        {
            _episodeRepository = episodeRepository;
        }
        public bool DeleteEpisode(int episodeId, int animeId)
        {
            return _episodeRepository.DeleteEpisode(episodeId, animeId);
        }
    }
}
