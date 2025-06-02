using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.EF;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Booking;

public class BookingRepository : IBookingRepository
{
    private readonly ApplicationDbContext context;

    public BookingRepository(ApplicationDbContext context)
    {
        this.context = context;
    }

    public async Task<BookingDao> Add(BookingDao dao)
    {
        var data = context.Bookings.Add(dao);
        await context.SaveChangesAsync();
        return data.Entity;
    }

    public async Task<bool> Delete(int id)
    {
        var entity = await context.Bookings.FindAsync(id);
        if (entity == null)
        {
            return false; 
        }
        context.Bookings.Remove(entity);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<List<BookingDao>> GetAll()
    {
        return await context.Bookings
            .Include(b => b.Workspace)
            .OrderByDescending(b => b.StartDate)
            .ToListAsync();
    }

    public async Task<BookingDao> GetById(int id)
    {
        return await context.Bookings
            .Include(b => b.Workspace)
            .FirstOrDefaultAsync(b => b.Id == id)
            ?? throw new InvalidOperationException($"There is no booking with id {id}");
    }

    public async Task<BookingDao> Update(BookingDao booking)
    {
        var data = context.Bookings.Update(booking);
        await context.SaveChangesAsync();

        return data.Entity;
    }
}
