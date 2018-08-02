using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewPractike.Models;

namespace NewPractike.Controllers
{
    [Route("api")]
    public class HomeController : Controller
    {
        
        [HttpGet()]
        public IActionResult GetDay()
        {   
            return View(DayContext.Current.Days);
        }
        public IActionResult GetOneDay(int id)
        {
            var DaytoReturn = DayContext.Current.Days.FirstOrDefault(c => c.Id == id);
            if (DaytoReturn == null)
            { return NotFound(); }
            return Ok(DaytoReturn);
        }
        [HttpDelete("delete/{id}")]
        //[HttpPut("update/{id}")]
        [HttpGet("addend")]
        public IActionResult AddDay()
        {
            return View();
        }

        [HttpGet("test")]
        public IActionResult Test()
        {
            return View();
        }
    }
}
