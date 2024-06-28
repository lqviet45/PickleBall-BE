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

        CreateMap<CreateBookingCommand, Booking>().ReverseMap();

        CreateMap<Booking, BookingDto>()
            // .ForMember(
            //     dest => dest.CourtYardId,
            //     opt => opt.MapFrom(src => src.CourtYardId ?? Guid.Empty)
            // )
            .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date))
            .ForMember(dest => dest.CourtGroup, opt => opt.MapFrom(src => src.CourtGroup))
            .ReverseMap();

        CreateMap<City, CityDto>().ReverseMap();

        CreateMap<CourtGroup, CourtGroupDto>()
            .ForMember(
                dest => dest.Location,
                opt =>
                    opt.MapFrom(src =>
                        src.Ward != null
                        && src.Ward.District != null
                        && src.Ward.District.City != null
                            ? $"{src.Ward.Name}, {src.Ward.District.Name}, {src.Ward.District.City.Name}"
                            : null
                    )
            )
            .ReverseMap();

        CreateMap<CourtYard, CourtYardDto>().ReverseMap();

        CreateMap<Date, DateDto>().ReverseMap();

        CreateMap<District, DistrictDto>().ReverseMap();

        CreateMap<Slot, SlotDto>().ReverseMap();

        CreateMap<Transaction, TransactionDto>().ReverseMap();

        CreateMap<Wallet, WalletDto>().ReverseMap();

        CreateMap<Media, MediaDto>().ReverseMap();

        CreateMap<Ward, WardDto>().ReverseMap();

        CreateMap<BookMark, BookMarkDto>().ReverseMap();
    }
}
