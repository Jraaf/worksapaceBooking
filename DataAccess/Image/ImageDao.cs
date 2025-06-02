using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Workspace;

namespace DataAccess.Image;

public class ImageDao
{
    public int Id { get; set; }
    public string Url { get; set; }
    public int WorkspaceId { get; set; }
    public WorkspaceDao Workspace { get; set; }
}
