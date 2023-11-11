using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingBooking;

        public BookingController(IBookingService bookingBooking)
        {
            _bookingBooking = bookingBooking;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingBooking.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingBooking.TInsert(booking);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingBooking.TGetByID(id);
            _bookingBooking.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingBooking.TUpdate(booking);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _bookingBooking.TGetByID(id);
            return Ok(values);
        }
        //[HttpPut("UpdateReservationStatusApproved")]
        //public IActionResult UpdateReservationStatusApproved(Booking booking)
        //{
        //    _bookingBooking.TBookingStatusChangeApproved(booking);
        //    return Ok();
        //}
        [HttpPut("UpdateReservationStatusApproved")]
        public IActionResult UpdateReservationStatusApproved(int id)
        {
            _bookingBooking.TBookingStatusChangeApproved(id);
            return Ok();
        }
    }
}
