using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Models
{
    public class AnimeDomain
    {
        public int AnimeId { get; set; }
        public string Title { get; set; }
        public string OriginalTitle { get; set; }
        public string Synopsis { get; set; }
        public DateTime RealeaseYear { get; set; }
    }
}
