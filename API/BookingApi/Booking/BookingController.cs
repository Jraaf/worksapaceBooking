using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Services.Booking;

namespace BookingApi.Booking;

[Route("api/[controller]")]
[ApiController]
public class BookingController : ControllerBase
{
    private readonly IBookingService service;
    private readonly IMapper mapper;

    public BookingController(IBookingService service, IMapper mapper)
    {
        this.service = service;
        this.mapper = mapper;
    }

    [HttpGet("getAll")]
    public async Task<IActionResult> GetAll()
    {
        var Bookings = await service.GetAll();
        return Ok(Bookings);
    }

    [HttpGet("getById")]
    public async Task<IActionResult> GetById(int id)
    {
        var data = await service.GetById(id);
        return Ok(data);
    }

    [HttpPost("/add")]
    public async Task<IActionResult> Add(CreateBookingDto booking)
    {
        if (booking == null)
        {
            return BadRequest("Booking data is null");
        }
        var dto = mapper.Map<BookingDto>(booking);
        var data = await service.Add(dto);
        return Ok(data);
    }
    [HttpPut("/{id}/update")]
    public async Task<IActionResult> Update(int id, CreateBookingDto booking)
    {
        var dto = mapper.Map<BookingDto>(booking);
        dto.Id = id;
        var data = await service.Update(dto);
        return Ok(data);
    }
    [HttpDelete("/{id}/delete")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await service.Delete(id);

        return NoContent();
    }
}
