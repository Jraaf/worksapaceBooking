using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Booking;

public interface IBookingRepository
{
    Task<BookingDao> Add(BookingDao dao);
    Task<List<BookingDao>> GetAll();
    Task<BookingDao> GetById(int id);
    Task<BookingDao> Update(BookingDao booking);
    Task<bool> Delete(int id);
}
