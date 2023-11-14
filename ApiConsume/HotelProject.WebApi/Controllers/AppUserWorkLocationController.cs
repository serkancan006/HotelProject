using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserWorkLocationController : ControllerBase
    {
        private readonly IAppUserService appUserService;

        public AppUserWorkLocationController(IAppUserService appUserService)
        {
            this.appUserService = appUserService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            //var values = appUserService.TUserListWithWorkLocation();
            Context context = new Context();
            var values = context.Users.Include(x => x.WorkLocation).Select(y => new   //AppUserWorkLocationViewModel
            {
                Name = y.Name,
                Surname = y.Surname,
                WorkLocationID = y.WorkLocationID,
                WorkLocationName = y.WorkLocation.WorkLocationName
            }).ToList();
            return Ok(values);
        }
    }
}
