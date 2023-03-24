using ploomesTest.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Application.Interfaces
{
    public interface IGenreApplication
    {
        public List<vmGenre> ListGenreByAnimeId(int animeId);
        public List<vmGenre> ListAllGenre();
        public bool UpdateGenre(vmGenre vmGenre);
        public bool InsertGenre(vmGenre vmGenre);
    }
}
