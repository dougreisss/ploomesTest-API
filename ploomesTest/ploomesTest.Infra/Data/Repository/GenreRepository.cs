using Microsoft.Extensions.Configuration;
using ploomesTest.Domain.Interfaces.Repository;
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
    public class GenreRepository : IGenreRepository
    {
        private readonly EnviromentDatabase environment = EnviromentDatabase.AMN;

        public List<GenreDomain> ListAllGenre()
        {
            DbConfigRepository dbConfig = new DbConfigRepository();
            return dbConfig.ExecuteList<GenreDomain>(environment, "AMN.spLSTAllGenre", null);
        }

        public List<GenreDomain> ListGenreByAnimeId(int animeId)
        {
            DbConfigRepository dbConfig = new DbConfigRepository();

            return dbConfig.ExecuteList<GenreDomain>(environment, "AMN.spLSTGenreByAnimeId", new
            {
                AnimeId = animeId
            });
        }
        public bool UpdateGenre(GenreDomain genreDomain)
        {
            DbConfigRepository dbConfig = new DbConfigRepository();

            int ret = dbConfig.ExecuteNonQuery(environment, "AMN.spUPDGenre", new
            {
                GenreId = genreDomain.GenreId,
                GenreName = genreDomain.GenreName
            });

            return ret > 0 ? true : false;
        }
    }
}
