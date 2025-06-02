using Services.Workspace;

namespace BookingApi.Booking;

public class CreateBookingDto
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int WorksapceId { get; set; }
    public string BookedEmail { get; set; }
}
