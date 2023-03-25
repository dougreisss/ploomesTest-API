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

        public List<EpisodeDomain> ListEpisodeByAnimeId(int animeId)
        {
            DbConfigRepository dbConfig = new DbConfigRepository();
            return dbConfig.ExecuteList<EpisodeDomain>(environment, "AMN.spLSTEpisodeByAnimeId", new
            {
                AnimeId = animeId
            });
        }
    }
}
