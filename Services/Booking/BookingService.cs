using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess.Booking;

namespace Services.Booking;

public class BookingService : IBookingService
{
    private readonly IMapper mapper;
    private readonly IBookingRepository repo;

    public BookingService(IMapper mapper, IBookingRepository repo)
    {
        this.mapper = mapper;
        this.repo = repo;
    }

    public async Task<BookingDto> Add(BookingDto booking)
    {
        var dao = mapper.Map<BookingDao>(booking);
        var data = await repo.Add(dao);

        return mapper.Map<BookingDto>(data);
    }

    public Task<bool> Delete(int id)
    {
        return repo.Delete(id);
    }

    public async Task<List<BookingDto>> GetAll()
    {
        var data = await repo.GetAll();

        return mapper.Map<List<BookingDto>>(data);
    }

    public async Task<BookingDto> GetById(int id)
    {
        var data = await repo.GetById(id)
            ?? throw new InvalidOperationException($"There is no booking with id {id}");

        return mapper.Map<BookingDto>(data);
    }

    public async Task<BookingDto> Update(BookingDto booking)
    {
        var newEntity = mapper.Map<BookingDao>(booking);
        var data = await repo.Update(newEntity);

        return mapper.Map<BookingDto>(data);
    }
}
