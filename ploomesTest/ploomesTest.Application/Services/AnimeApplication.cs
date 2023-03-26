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
        private readonly IDeleteAnimeDomain _deleteAnimeDomain;
        private readonly IInsertAnimeGenreDomain _insertAnimeGenreDomain;

        public AnimeApplication(
            IListAllAnimesDomain listAllAnimesDomain,
            IListAllAnimesByIdDomain listAllAnimesByIdDomain,
            IInsertAnimeDomain insertAnimeDomain,
            IUpdateAnimeDomain updateAnimeDomain,
            IDeleteAnimeDomain deleteAnimeDomain,
            IInsertAnimeGenreDomain insertAnimeGenreDomain
            )
        {
            _listAllAnimesDomain = listAllAnimesDomain;
            _listAllAnimesByIdDomain = listAllAnimesByIdDomain;
            _insertAnimeDomain = insertAnimeDomain;
            _updateAnimeDomain = updateAnimeDomain;
            _deleteAnimeDomain = deleteAnimeDomain;
            _insertAnimeGenreDomain = insertAnimeGenreDomain;
        }

        public bool DeleteAnime(int animeId)
        {
            return _deleteAnimeDomain.DeleteAnime(animeId);
        }

        public bool InsertAnime(vmInsertAnime vmAnime)
        {
            return _insertAnimeDomain.InsertAnime(Read<AnimeDomain>(vmAnime));
        }

        public bool InsertAnimeGenre(int animeId, int genreId)
        {
            return _insertAnimeGenreDomain.InsertAnimeGenre(animeId, genreId);
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
