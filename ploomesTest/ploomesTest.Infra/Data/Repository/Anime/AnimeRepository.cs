using ploomesTest.Domain.Interfaces.Repository.Anime;
using ploomesTest.Domain.Models;
using ploomesTest.Infra.Data.DbConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ploomesTest.Domain.Models.Enums.Enviroment;

namespace ploomesTest.Infra.Data.Repository
{
    public class AnimeRepository : IAnimeRepository
    {
        private readonly EnviromentDatabase environment = EnviromentDatabase.AMN;

        public bool DeleteAnime(int animeId)
        {
            DbConfigRepository dbConfig = new DbConfigRepository();
            int ret = dbConfig.ExecuteNonQuery(environment, "AMN.spDELAnime", new {
            
                AnimeId = animeId

            });

            return ret > 0 ? true : false;
        }

        public bool InsertAnime(AnimeDomain animeDomain)
        {
            DbConfigRepository dbConfig = new DbConfigRepository();

            int ret = dbConfig.ExecuteNonQuery(environment, "AMN.spINSAnime", new
            {
                Title = animeDomain.Title,
                OriginalTitle = animeDomain.OriginalTitle,
                Synopsis = animeDomain.Synopsis,
                RealeaseYear = animeDomain.RealeaseYear,
                StudioId = animeDomain.StudioId
            });

            return ret > 0 ? true : false;
        }

        public List<AllAnimesDomain> ListAllAnimes()
        {
            DbConfigRepository dbConfig = new DbConfigRepository();
            return dbConfig.ExecuteList<AllAnimesDomain>(environment, "AMN.spLSTAllAnimes", null);
        }

        public AllAnimesDomain ListAllAnimesById(int animeId, int episodeId)
        {
            DbConfigRepository dbConfig = new DbConfigRepository();
            return dbConfig.ExecuteSelect<AllAnimesDomain>(environment, "AMN.spLSTAllAnimesByAnimeIdAndEpisodeId", new
            {
                AnimeId = animeId,
                EpisodeId = episodeId
            });
        }

        public bool UpdateAnime(AnimeDomain animeDomain)
        {
            DbConfigRepository dbConfig = new DbConfigRepository();
            int ret = dbConfig.ExecuteNonQuery(environment, "AMN.spUPDAnime", new
            {
                AnimeId = animeDomain.AnimeId,
                Title = animeDomain.Title,
                OriginalTitle = animeDomain.OriginalTitle,
                Synopsis = animeDomain.Synopsis,
                RealeaseYear = animeDomain.RealeaseYear,
                StudioId = animeDomain.StudioId
            });

            return ret > 0 ? true : false;
        }
    }
}
