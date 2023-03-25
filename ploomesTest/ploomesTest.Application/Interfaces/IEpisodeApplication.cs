using ploomesTest.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Application.Interfaces
{
    public interface IEpisodeApplication
    {
        public List<vmEpisode> ListEpisodeByAnimeId(int animeId);
        public bool InsertEpisode(vmEpisode episode);
        public bool UpdateEpisode(vmEpisode episode);
    }
}
