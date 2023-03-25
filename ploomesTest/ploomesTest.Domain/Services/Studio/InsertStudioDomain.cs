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
    public class InsertStudioDomain : IInsertStudioDomain
    {
        private readonly IStudioRepository _studioRepository;

        public InsertStudioDomain(IStudioRepository studioRepository)
        {
            _studioRepository = studioRepository;
        }
        public bool InsertStudio(StudioDomain studioDomain)
        {
            return _studioRepository.InsertStudio(studioDomain);
        }
    }
}
