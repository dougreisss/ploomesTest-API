using ploomesTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Interfaces.Command.Episode
{
    public interface IListEpisodeByAnimeIdDomain
    {
        public List<EpisodeDomain> ListEpisodeByAnimeId(int animeId);
    }
}
