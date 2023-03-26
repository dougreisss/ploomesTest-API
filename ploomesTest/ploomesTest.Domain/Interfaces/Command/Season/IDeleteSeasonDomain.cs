using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Interfaces.Command.Season
{
    public interface IDeleteSeasonDomain
    {
        public bool DeleteSeason(int seasonId);
    }
}
