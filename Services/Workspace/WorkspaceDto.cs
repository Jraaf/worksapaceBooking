using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Workspace;

namespace Services.Workspace;

public class WorkspaceDto
{
    public int Id { get; set; }
    public int Capacity { get; set; }
    public WorkspaceType Type { get; set; }
    public List<string> Images { get; set; }
}
