using ploomesTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Interfaces.Repository.Anime
{
    public interface IAnimeRepository
    {
        public List<AllAnimesDomain> ListAllAnimes();
        public AllAnimesDomain ListAllAnimesById(int animeId, int episodeId);
        public bool InsertAnime(AnimeDomain animeDomain);
        public bool UpdateAnime(AnimeDomain animeDomain);
        public bool DeleteAnime(int animeId);
        public bool InsertAnimeGenre(int animeId, int genreId);
    }
}
