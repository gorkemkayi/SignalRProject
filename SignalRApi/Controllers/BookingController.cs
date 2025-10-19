using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.BookingDto;
using SignalR.EntityLayer.DAL.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;

        public BookingController(IBookingService bookingService, IMapper mapper)
        {
            _bookingService = bookingService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult BookingList()
        {
            var values=_bookingService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            var booking = _mapper.Map<Booking>(createBookingDto);
            _bookingService.TAdd(booking);
            return Ok("Rezervasyon oluşturuldu.");
        }
        [HttpDelete]
        public IActionResult DelteBooking(int id)
        {
            var booking= _bookingService.TGetById(id);
            _bookingService.TDelete(booking);
            return Ok("Rezervasyon silindi.");
        }
        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            var booking=_mapper.Map<Booking>(updateBookingDto);
            _bookingService.TUpdate(booking);
            return Ok("Rezervasyon güncellendi.");
        }
        [HttpGet("GetBooking")]
        public IActionResult GetBooking(int id)
        {
            var booking = _bookingService.TGetById(id);
            return Ok(booking);
        }

    }
}
