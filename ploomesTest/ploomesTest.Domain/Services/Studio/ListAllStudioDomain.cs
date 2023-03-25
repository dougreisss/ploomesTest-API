using ploomesTest.Domain.Interfaces.Command.Studio;
using ploomesTest.Domain.Interfaces.Repository.Studio;
using ploomesTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Services.Studio
{
    public class ListAllStudioDomain : IListAllStudioDomain
    {
        private readonly IStudioRepository _studioRepository;
        public ListAllStudioDomain(IStudioRepository studioRepository)
        {
            _studioRepository = studioRepository;
        }
        public List<StudioDomain> ListAllStudio()
        {
            return _studioRepository.ListAllStudio();
        }
    }
}
