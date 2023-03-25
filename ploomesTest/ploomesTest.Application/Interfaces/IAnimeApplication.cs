using ploomesTest.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Application.Interfaces
{
    public interface IAnimeApplication
    {
        public List<vmAllAnimes> ListAllAnimes();
        public vmAllAnimes ListAllAnimesById(int animeId, int episodeId);
        public bool InsertAnime(vmAnime vmAnime);
        public bool UpdateAnime(vmAnime vmAnime);

    }
}
