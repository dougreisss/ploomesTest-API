using ploomesTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Interfaces.Repository.Season
{
    public interface IInsertSeasonDomain
    {
        public bool InsertSeason(SeasonDomain seasonDomain);
    }
}
