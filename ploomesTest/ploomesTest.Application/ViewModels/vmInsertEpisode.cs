using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Application.ViewModels
{
    public class vmInsertEpisode
    {
        public int AnimeId { get; set; }
        public string EpisodeName { get; set; }
        public string EpisodeLength { get; set; }
        public string EpisodeSynopsis { get; set; }
        public DateTime EpisodeRealease { get; set; }
        public int SeasonId { get; set; }
    }
}
