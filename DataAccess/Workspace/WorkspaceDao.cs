using DataAccess.Image;

namespace DataAccess.Workspace;

public class WorkspaceDao
{
    public int Id { get; set; }
    public int Capacity { get; set; }
    public WorkspaceType Type { get; set; }
    public List<ImageDao> Images { get; set; }
}

public enum WorkspaceType
{
    OpenSpace,
    PrivateRoom,
    MeetingRoom
}
