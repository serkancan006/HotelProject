using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkLocationController : ControllerBase
    {
        private readonly IWorkLocationService _WorkLocationService;

        public WorkLocationController(IWorkLocationService WorkLocationService)
        {
            _WorkLocationService = WorkLocationService;
        }

        [HttpGet]
        public IActionResult WorkLocationList()
        {
            var values = _WorkLocationService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddWorkLocation(WorkLocation WorkLocation)
        {
            _WorkLocationService.TInsert(WorkLocation);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteWorkLocation(int id)
        {
            var values = _WorkLocationService.TGetByID(id);
            _WorkLocationService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateWorkLocation(WorkLocation WorkLocation)
        {
            _WorkLocationService.TUpdate(WorkLocation);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetWorkLocation(int id)
        {
            var values = _WorkLocationService.TGetByID(id);
            return Ok(values);
        }
    }
}
