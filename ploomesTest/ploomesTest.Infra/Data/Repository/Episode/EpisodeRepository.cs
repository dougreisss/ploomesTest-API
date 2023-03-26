using ploomesTest.Domain.Interfaces.Repository.Episode;
using ploomesTest.Domain.Models;
using ploomesTest.Infra.Data.DbConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ploomesTest.Domain.Models.Enums.Enviroment;

namespace ploomesTest.Infra.Data.Repository.Episode
{
    public class EpisodeRepository : IEpisodeRepository
    {
        private readonly EnviromentDatabase environment = EnviromentDatabase.AMN;

        public bool DeleteEpisode(int episodeId, int animeId)
        {
            DbConfigRepository dbConfig = new DbConfigRepository();
            int ret = dbConfig.ExecuteNonQuery(environment, "AMN.spDELEpisode", new { 
            
                EpisodeId = episodeId,
                AnimeId = animeId

            });

            return ret > 0 ? true : false;
        }

        public bool InsertEpisode(EpisodeDomain episodeDomain)
        {
            DbConfigRepository dbConfig = new DbConfigRepository();

            int ret = dbConfig.ExecuteNonQuery(environment, "AMN.spINSEpisode", new {

                AnimeId = episodeDomain.AnimeId,
                EpisodeName = episodeDomain.EpisodeName,
                EpisodeLength = DateTime.Parse(episodeDomain.EpisodeLength),
                EpisodeSynopsis = episodeDomain.EpisodeSynopsis,
                EpisodeRealease = episodeDomain.EpisodeRealease,
                SeasonId = episodeDomain.SeasonId
            });

            return ret > 0 ? true : false;
        }

        public List<EpisodeDomain> ListEpisodeByAnimeId(int animeId)
        {
            DbConfigRepository dbConfig = new DbConfigRepository();
            return dbConfig.ExecuteList<EpisodeDomain>(environment, "AMN.spLSTEpisodeByAnimeId", new
            {
                AnimeId = animeId
            });
        }

        public bool UpdateEpisode(EpisodeDomain episodeDomain)
        {
            DbConfigRepository dbConfig = new DbConfigRepository();
            int ret = dbConfig.ExecuteNonQuery(environment, "AMN.spUPDEpisode", new
            {
                EpisodeId = episodeDomain.EpisodeId,
                AnimeId = episodeDomain.AnimeId,
                EpisodeName = episodeDomain.EpisodeName,
                EpisodeLength = episodeDomain.EpisodeLength,
                EpisodeSynopsis = episodeDomain.EpisodeSynopsis,
                EpisodeRealease = episodeDomain.EpisodeRealease,
                SeasonId = episodeDomain.SeasonId
            });

            return ret > 0 ? true : false;
        }
    }
}
