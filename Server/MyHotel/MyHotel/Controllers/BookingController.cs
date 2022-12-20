using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyHotel.Data;
using MyHotel.Models;
using MyHotel.Models.RequestModels;
using System.Security.Claims;

namespace MyHotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : Controller
    {
        private readonly ApplicationDbContext _db;



        public BookingController(ApplicationDbContext db)

        {

            _db = db;

        }

        [HttpGet]

        public async Task<ActionResult> GetHotels()

        {
            var rooms = await _db.Rooms.ToListAsync();
            return Ok(new ResponseModel<IEnumerable<Room>>()
            {
                Data = rooms
            });
        }

        [HttpGet("ViewBooking")]

        public async Task<IActionResult> ViewBooking()
        {
            var cid = HttpContext.User.FindFirstValue("UserId");
            var booking = _db.Bookings.Where(i => i.CustomerId == cid).FirstOrDefault();
            //var booking = await _db.Bookings.ToListAsync();
            return Ok(new ResponseModel<Booking>()
            {
                Data = booking
            });
        }

        [HttpPost]
        public async Task<IActionResult> Booking(BookingRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var booking = new Booking()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Address = model.Address,
                CheckIn = model.CheckIn,
                CheckOut = model.CheckOut,
                Guest= model.Guest,
                NoRoom=model.NoRoom,
                CustomerId= model.CustomerId,
                RoomId= model.RoomId

            };
            await _db.Bookings.AddAsync(booking);
            await _db.SaveChangesAsync();
            return Ok();

        }
    }
}

