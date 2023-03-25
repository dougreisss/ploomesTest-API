using ploomesTest.Application.Interfaces;
using ploomesTest.Application.ViewModels;
using ploomesTest.Domain.Interfaces.Command.Anime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Application.Services
{
    public class AnimeApplication : ApplicationBase, IAnimeApplication
    {
        private readonly IListAllAnimesDomain _listAllAnimesDomain;

        public AnimeApplication(IListAllAnimesDomain listAllAnimesDomain)
        {
            _listAllAnimesDomain = listAllAnimesDomain;
        }

        public List<vmAllAnimes> ListAllAnimes()
        {
            return List<vmAllAnimes>(_listAllAnimesDomain.ListAllAnimes()); ;
        }
    }
}
