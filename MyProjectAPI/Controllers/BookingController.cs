using BusinessLayer.Abstract;
using DtoLayer.AboutDto;
using DtoLayer.BookingDto;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            Booking booking = new Booking()
            {
                BookingMail = createBookingDto.BookingMail,
                BookingDate = createBookingDto.BookingDate,
                BookingName = createBookingDto.BookingName,
                BookingPersonCount = createBookingDto.BookingPersonCount,
                BookingPhone = createBookingDto.BookingPhone
            };
            ;_bookingService.TAdd(booking);
            return Ok("Rezervasyon yapıldı");
        }
        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            _bookingService.TDelete(value);
            return Ok("Rezervasyon silindi");
        }
        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            Booking booking = new Booking()
            {
                BookingMail = updateBookingDto.BookingMail,
                BookingDate = updateBookingDto.BookingDate,
                BookingId = updateBookingDto.BookingId,
                BookingName= updateBookingDto.BookingName,
                BookingPersonCount= updateBookingDto.BookingPersonCount,
                BookingPhone= updateBookingDto.BookingPhone
            };
            _bookingService.TUpdate(booking);
            return Ok("Rezervasyon Güncellendi");
        }
        [HttpGet("GetBooking")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            return Ok(value);
        }
    }
}
