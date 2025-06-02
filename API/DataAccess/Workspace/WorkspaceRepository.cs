using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.EF;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Workspace;

public class WorkspaceRepository : IWorkspaceRepository
{
    private readonly ApplicationDbContext context;

    public WorkspaceRepository(ApplicationDbContext context)
    {
        this.context = context;
    }
    public async Task<List<WorkspaceDao>> GetAll()
    {
        return await context.Workspaces
            .Include(w=>w.Images)
            .ToListAsync();
    }

    public async Task<WorkspaceDao> GetById(int id)
    {
        return await context.Workspaces
            .Include(w=>w.Images)
            .FirstOrDefaultAsync(w=>w.Id == id);
    }
}
