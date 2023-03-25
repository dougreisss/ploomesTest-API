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

        public List<AllAnimesDomain> ListAllAnimes()
        {
            DbConfigRepository dbConfig = new DbConfigRepository();
            return dbConfig.ExecuteList<AllAnimesDomain>(environment, "AMN.spLSTAllAnimes", null);
        }
    }
}
