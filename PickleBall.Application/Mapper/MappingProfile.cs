using AutoMapper;
using PickleBall.Application.UseCases.UseCase_Booking.Commands.CreateBooking;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ApplicationUser, ApplicationUserDto>().ReverseMap();
        CreateMap<Booking, BookingDto>().ReverseMap();
        CreateMap<Booking, CreateBookingCommand>()
            .ForMember(dest => dest.DateWorking, opt => opt.Ignore())
            .ReverseMap();
        CreateMap<City, CityDto>().ReverseMap();
        CreateMap<CourtGroup, CourtGroupDto>().ReverseMap();
        CreateMap<CourtYard, CourtYardDto>().ReverseMap();
        CreateMap<District, DistrictDto>().ReverseMap();
    }
}
