using ploomesTest.Domain.Interfaces.Repository.Season;
using ploomesTest.Domain.Models;
using ploomesTest.Infra.Data.DbConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ploomesTest.Domain.Models.Enums.Enviroment;

namespace ploomesTest.Infra.Data.Repository.Season
{
    public class SeasonRepository : ISeasonRepository
    {
        private readonly EnviromentDatabase environment = EnviromentDatabase.AMN;

        public bool InsertSeason(SeasonDomain seasonDomain)
        {
            DbConfigRepository dbConfig = new DbConfigRepository();
            int ret = dbConfig.ExecuteNonQuery(environment, "AMN.spINSSeason", new {

                SeasonName = seasonDomain.SeasonName

            });

            return ret > 0 ? true : false;
        }

        public List<SeasonDomain> ListAllSeason()
        {
            DbConfigRepository dbConfig = new DbConfigRepository();
            return dbConfig.ExecuteList<SeasonDomain>(environment, "AMN.spLSTAllSeason", null);
        }

        public List<SeasonDomain> ListSeasonByAnimeId(int animeId)
        {
            DbConfigRepository dbConfig = new DbConfigRepository();
            return dbConfig.ExecuteList<SeasonDomain>(environment, "AMN.spLSTSeasonByAnimeId", new { 
            
                AnimeId = animeId

            });
        }

        public bool UpdateSeason(SeasonDomain seasonDomain)
        {
            DbConfigRepository dbConfig = new DbConfigRepository();
            int ret = dbConfig.ExecuteNonQuery(environment, "AMN.spUPDSeason", new
            {

                SeasonId = seasonDomain.SeasonId,
                Seasonname = seasonDomain.SeasonName

            });

            return ret > 0 ? true : false;
        }
    }
}
