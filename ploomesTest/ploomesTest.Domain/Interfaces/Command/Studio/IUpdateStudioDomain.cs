using ploomesTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Interfaces.Command.Studio
{
    public interface IUpdateStudioDomain
    {
        public bool UpdateStudio(StudioDomain studioDomain);
    }
}
