using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Workspace;

public interface IWorkspaceRepository
{
    Task<List<WorkspaceDao>> GetAll();
    Task<WorkspaceDao> GetById(int id);
}
