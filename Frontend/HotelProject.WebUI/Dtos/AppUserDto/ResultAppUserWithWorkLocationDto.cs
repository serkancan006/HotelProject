﻿using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebUI.Dtos.AppUserDto
{
    public class ResultAppUserWithWorkLocationDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        
        //public string City { get; set; }
        //public string ImageUrl { get; set; }
        //public bool Status { get; set; }


        //public string WorkDepartment { get; set; }
        public int WorkLocationID { get; set; }
        public string WorkLocationName { get; set; }
        //public WorkLocation WorkLocation { get; set; }
    }
}
