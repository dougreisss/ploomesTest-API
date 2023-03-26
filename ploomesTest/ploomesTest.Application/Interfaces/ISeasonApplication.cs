using ploomesTest.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Application.Interfaces
{
    public interface ISeasonApplication 
    {
        public List<vmSeason> ListSeasonByAnimeId(int animeId);
        public List<vmSeason> ListAllSeason();
        public bool InsertSeason(vmSeason vmSeason);
        public bool UpdateSeason(vmSeason vmSeason);
        public bool DeleteSeason(int seasonId);
    }
}
