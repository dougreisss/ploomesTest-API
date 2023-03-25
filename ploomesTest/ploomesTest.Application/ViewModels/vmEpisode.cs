using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Application.ViewModels
{
    public class vmEpisode
    {
        public int EpisodeId { get; set; }
        public int AnimeId { get; set; }
        public string EpisodeName { get; set; }
        public string EpisodeLength { get; set; }
        public string EpisodeSynopsis { get; set; }
        public DateTime EpisodeRealease { get; set; }
    }
}
