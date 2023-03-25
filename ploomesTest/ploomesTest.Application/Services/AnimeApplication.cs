using ploomesTest.Application.Interfaces;
using ploomesTest.Application.ViewModels;
using ploomesTest.Domain.Interfaces.Command.Anime;
using ploomesTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Application.Services
{
    public class AnimeApplication : ApplicationBase, IAnimeApplication
    {
        private readonly IListAllAnimesDomain _listAllAnimesDomain;
        private readonly IListAllAnimesByIdDomain _listAllAnimesByIdDomain;
        private readonly IInsertAnimeDomain _insertAnimeDomain;
        private readonly IUpdateAnimeDomain _updateAnimeDomain;

        public AnimeApplication(
            IListAllAnimesDomain listAllAnimesDomain,
            IListAllAnimesByIdDomain listAllAnimesByIdDomain,
            IInsertAnimeDomain insertAnimeDomain,
            IUpdateAnimeDomain updateAnimeDomain
            )
        {
            _listAllAnimesDomain = listAllAnimesDomain;
            _listAllAnimesByIdDomain = listAllAnimesByIdDomain;
            _insertAnimeDomain = insertAnimeDomain;
            _updateAnimeDomain = updateAnimeDomain;
        }

        public bool InsertAnime(vmAnime vmAnime)
        {
            return _insertAnimeDomain.InsertAnime(Read<AnimeDomain>(vmAnime));
        }

        public List<vmAllAnimes> ListAllAnimes()
        {
            return List<vmAllAnimes>(_listAllAnimesDomain.ListAllAnimes()); ;
        }

        public vmAllAnimes ListAllAnimesById(int animeId, int episodeId)
        {
            return Read<vmAllAnimes>(_listAllAnimesByIdDomain.ListAllAnimesById(animeId, episodeId));
        }

        public bool UpdateAnime(vmAnime vmAnime)
        {
            return _updateAnimeDomain.UpdateAnime(Read<AnimeDomain>(vmAnime));
        }
    }
}
