using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Application.ViewModels
{
    public class vmAnime
    {
        public int AnimeId { get; set; }
        public string Title { get; set; }
        public string OriginalTitle { get; set; }
        public string Synopsis { get; set; }
        public DateTime RealeaseYear { get; set; }
        public int StudioId { get; set; }
    }
}
