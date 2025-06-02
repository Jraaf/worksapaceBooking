using AutoMapper;
using DataAccess.Booking;
using Services.Booking;

namespace BookingApi.Booking;

public class BookingProfile : Profile
{
    public BookingProfile()
    {
        CreateMap<BookingDao, BookingDto>()
            .ForMember(dest => dest.WorksapceId, opt => opt.MapFrom(src => src.WorksapceId)) 
            .ForMember(dest => dest.BookedEmail, opt => opt.MapFrom(src => src.BookedEmail))
            .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
            .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate))
            .ForMember(dest => dest.Workspace, opt => opt.MapFrom(src => src.Workspace));

        CreateMap<BookingDto, BookingDao>();
        CreateMap<CreateBookingDto, BookingDto>();
    }
}
