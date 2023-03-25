using ploomesTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Interfaces.Repository.Episode
{
    public interface IEpisodeRepository
    {
        public List<EpisodeDomain> ListEpisodeByAnimeId(int animeId);
    }
}
