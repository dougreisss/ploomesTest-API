using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Models
{
    public class EpisodeDomain
    {
        public int EpisodeId { get; set; }
        public string EpisodeName { get; set; }
        public DateTime EpisodeLength { get; set; }
        public string EpisodeSynopsis { get; set; }
        public DateTime EpisodeRealease { get; set; }
    }
}
