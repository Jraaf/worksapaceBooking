using DataAccess.Workspace;

namespace DataAccess.Booking;

public class BookingDao
{
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int WorksapceId { get; set; }
    public string BookedEmail { get; set; }
    public WorkspaceDao Workspace { get; set; }
}
