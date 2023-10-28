using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RoomController : ControllerBase
	{
		private readonly IRoomService _soomService;

		public RoomController(IRoomService roomService)
		{
			_soomService = roomService;
		}

		[HttpGet]
		public IActionResult RoomList()
		{
			var values = _soomService.TGetList();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult AddRoom(Room room)
		{
			_soomService.TInsert(room);
			return Ok();
		}
		[HttpDelete]
		public IActionResult DeleteRoom(int id)
		{
			var values = _soomService.TGetByID(id);
			_soomService.TDelete(values);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateRoom(Room room)
		{
			_soomService.TUpdate(room);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetRoom(int id)
		{
			var values = _soomService.TGetByID(id);
			return Ok(values);
		}
	}
}
