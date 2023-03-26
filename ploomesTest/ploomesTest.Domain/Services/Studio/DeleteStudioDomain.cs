using ploomesTest.Domain.Interfaces.Command.Studio;
using ploomesTest.Domain.Interfaces.Repository.Studio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Services.Studio
{
    public class DeleteStudioDomain : IDeleteStudioDomain
    {
        private readonly IStudioRepository _studioRepository;

        public DeleteStudioDomain(IStudioRepository studioRepository)
        {
            _studioRepository = studioRepository;
        }

        public bool DeleteStudio(int studioId)
        {
            return _studioRepository.DeleteStudio(studioId);
        }
    }
}
