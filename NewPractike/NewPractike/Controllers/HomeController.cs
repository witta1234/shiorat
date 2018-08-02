using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewPractike.Models;

namespace NewPractike.Controllers
{
    public class HomeController : Controller
    {
        [Route("api")]
        //[HttpGet()]
        public IActionResult GetDay()
        {
            return Ok(DayContext.Current.Days);
        }

        //[HttpGet("{id}")]
        public IActionResult GetOneDay(int id)
        {
            var DaytoReturn = DayContext.Current.Days.FirstOrDefault(c => c.Id == id);
            if (DaytoReturn == null)
            { return NotFound(); }
            return Ok(DaytoReturn);
        }
        //[HttpDelete("delete/{id}")]
        //[HttpPut("update/{id}")]        
        //[HttpPost("add/{id}")]

        [Route("test")]
        public IActionResult Test()
        {
            return Content("Hello");
        }
    }
}
