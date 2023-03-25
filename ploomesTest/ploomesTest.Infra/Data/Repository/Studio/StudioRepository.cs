using ploomesTest.Domain.Interfaces.Repository.Studio;
using ploomesTest.Domain.Models;
using ploomesTest.Infra.Data.DbConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ploomesTest.Domain.Models.Enums.Enviroment;

namespace ploomesTest.Infra.Data.Repository.Studio
{
    public class StudioRepository : IStudioRepository
    {
        private readonly EnviromentDatabase environment = EnviromentDatabase.AMN;

        public bool InsertStudio(StudioDomain studioDomain)
        {
            DbConfigRepository dbConfig = new DbConfigRepository();

            int ret = dbConfig.ExecuteNonQuery(environment, "AMN.spINSStudio", new { 
            
                StudioName = studioDomain.StudioName

            });

            return ret > 0 ? true : false;
        }

        public List<StudioDomain> ListAllStudio()
        {
            DbConfigRepository dbConfig = new DbConfigRepository();
            return dbConfig.ExecuteList<StudioDomain>(environment, "AMN.spLSTAllStudio", null);
        }

        public bool UpdateStudio(StudioDomain studioDomain)
        {
            DbConfigRepository dbConfig = new DbConfigRepository();
            int ret = dbConfig.ExecuteNonQuery(environment, "AMN.spUPDStudio", new { 
            
                StudioId = studioDomain.StudioId,
                StudioName = studioDomain.StudioName

            });

            return ret > 0 ? true : false;
        }
    }
}
