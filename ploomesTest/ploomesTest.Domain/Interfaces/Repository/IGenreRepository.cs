using ploomesTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Interfaces.Repository
{
    public interface IGenreRepository
    {
        public List<GenreDomain> ListGenreByAnimeId(int animeId);
        public List<GenreDomain> ListAllGenre();
    }
}
