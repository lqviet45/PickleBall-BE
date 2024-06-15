using AutoMapper;
using PickleBall.Domain.DTOs;
using PickleBall.Domain.Entities;

namespace PickleBall.Application.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ApplicationUser, ApplicationUserDto>().ReverseMap();
        CreateMap<Booking, BookingDto>().ReverseMap();
        CreateMap<CourtGroup, CourtGroupDto>().ReverseMap();
        CreateMap<CourtYard, CourtYardDto>().ReverseMap();
        CreateMap<District, DistrictDto>().ReverseMap();
    }
}
