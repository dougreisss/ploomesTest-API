using ploomesTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Interfaces.Repository.Studio
{
    public interface IStudioRepository
    {
        public List<StudioDomain> ListAllStudio();
        public bool InsertStudio(StudioDomain studioDomain);
        public bool UpdateStudio(StudioDomain studioDomain);
    }
}
