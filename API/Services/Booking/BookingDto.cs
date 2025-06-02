using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Workspace;

namespace Services.Booking;

public class BookingDto
{
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int WorksapceId { get; set; }
    public string BookedEmail { get; set; }
    public WorkspaceDto Workspace { get; set; }
}
