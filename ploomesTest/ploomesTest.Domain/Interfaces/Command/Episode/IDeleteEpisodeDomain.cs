using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Interfaces.Command.Episode
{
    public interface IDeleteEpisodeDomain
    {
        public bool DeleteEpisode(int episodeId, int animeId);
    }
}
