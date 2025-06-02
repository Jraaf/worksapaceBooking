using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess.Workspace;

namespace Services.Workspace;

public class WorkspaceService : IWorkspaceService
{
    private readonly IMapper mapper;
    private readonly IWorkspaceRepository repo;

    public WorkspaceService(IMapper mapper, IWorkspaceRepository repo)
    {
        this.mapper = mapper;
        this.repo = repo;
    }
    public async Task<List<WorkspaceDto>> GetAll()
    {
        var data = await repo.GetAll();

        return mapper.Map<List<WorkspaceDto>>(data);
    }

    public async Task<WorkspaceDto> GetById(int id)
    {
        var data = await repo.GetById(id)
            ?? throw new InvalidOperationException($"There is no entity with id {id}");

        return mapper.Map<WorkspaceDto>(data);
    }
}
