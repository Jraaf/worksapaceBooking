using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Workspace;

namespace BookingApi.Workspace;

[Route("api/[controller]")]
[ApiController]
public class WorkspaceController : ControllerBase
{
    private readonly IWorkspaceService service;

    public WorkspaceController(IWorkspaceService service)
    {
        this.service = service;
    }
    [HttpGet("getAll")]
    public async Task<IActionResult> GetAll()
    {
        var workspaces = await service.GetAll();
        return Ok(workspaces);
    }
    [HttpGet("getById")]
    public async Task<IActionResult> GetById(int id)
    {
        var data = await service.GetById(id);
        return Ok(data);
    }
}
