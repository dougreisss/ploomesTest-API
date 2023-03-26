using ploomesTest.Application.Interfaces;
using ploomesTest.Application.ViewModels;
using ploomesTest.Domain.Interfaces.Command.Studio;
using ploomesTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Application.Services
{
    public class StudioApplication : ApplicationBase, IStudioApplication
    {
        private readonly IListAllStudioDomain _listAllStudioDomain;
        private readonly IInsertStudioDomain _insertStudioDomain;
        private readonly IUpdateStudioDomain _updateStudioDomain;
        private readonly IDeleteStudioDomain _deleteStudioDomain;

        public StudioApplication(
            IListAllStudioDomain listAllStudioDomain,
            IInsertStudioDomain insertStudioDomain,
            IUpdateStudioDomain updateStudioDomain,
            IDeleteStudioDomain deleteStudioDomain
        )
        {
            _listAllStudioDomain = listAllStudioDomain;
            _insertStudioDomain = insertStudioDomain;
            _updateStudioDomain = updateStudioDomain;
            _deleteStudioDomain = deleteStudioDomain;
        }

        public bool DeleteStudio(int studioId)
        {
            return _deleteStudioDomain.DeleteStudio(studioId);
        }

        public bool InsertStudio(vmInsertStudio studio)
        {
            return _insertStudioDomain.InsertStudio(Read<StudioDomain>(studio));
        }

        public List<vmStudio> ListAllStudio()
        {
            return List<vmStudio>(_listAllStudioDomain.ListAllStudio());
        }

        public bool UpdateStudio(vmStudio studio)
        {
            return _updateStudioDomain.UpdateStudio(Read<StudioDomain>(studio));
        }
    }
}
