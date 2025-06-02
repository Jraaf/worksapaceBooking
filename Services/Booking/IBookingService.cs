using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Booking;

public interface IBookingService
{
    Task<List<BookingDto>> GetAll();
    Task<BookingDto> GetById(int id);
    Task<BookingDto> Add(BookingDto booking);
    Task<BookingDto> Update(BookingDto booking);
    Task<bool> Delete(int id);
}
