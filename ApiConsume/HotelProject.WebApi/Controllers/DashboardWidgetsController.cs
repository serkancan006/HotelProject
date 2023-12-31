﻿using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardWidgetsController : ControllerBase
    {
        private readonly IStaffService _staffService;
        public DashboardWidgetsController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet("[action]")]
        public IActionResult StaffCount()
        {
            var values = _staffService.TGetStaffCount();
            return Ok(values);
        }
    }
}
