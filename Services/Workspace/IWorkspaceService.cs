using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Workspace;

public interface IWorkspaceService
{
    Task<List<WorkspaceDto>> GetAll();
    Task<WorkspaceDto> GetById(int id);
}
