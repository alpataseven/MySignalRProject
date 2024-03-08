using AutoMapper;
using DtoLayer.BookingDto;
using EntityLayer.Entities;

namespace MyProjectAPI.Mapping
{
    public class BookingMapping:Profile
    {
        public BookingMapping()
        {
                CreateMap<Booking, ResultBookingDto>().ReverseMap();
                CreateMap<Booking, CreateBookingDto>().ReverseMap();
                CreateMap<Booking, GetBookingDto>().ReverseMap();
                CreateMap<Booking, UpdateBookingDto>().ReverseMap();
        }
    }
}
