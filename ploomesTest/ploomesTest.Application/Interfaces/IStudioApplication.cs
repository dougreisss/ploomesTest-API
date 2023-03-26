using ploomesTest.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Application.Interfaces
{
    public interface IStudioApplication
    {
        public List<vmStudio> ListAllStudio();
        public bool InsertStudio(vmStudio studio);
        public bool UpdateStudio(vmStudio studio);
        public bool DeleteStudio(int studioId);
    }
}
