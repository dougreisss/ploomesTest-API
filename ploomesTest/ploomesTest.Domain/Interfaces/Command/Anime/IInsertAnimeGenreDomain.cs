using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Interfaces.Command.Anime
{
    public interface IInsertAnimeGenreDomain
    {
        public bool InsertAnimeGenre(int animeId, int genreId);
    }
}
