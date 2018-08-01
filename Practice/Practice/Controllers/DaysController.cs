using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practice.Models;

namespace Practice.Controllers
{
    [Route("api/days")]
    [ApiController]
    public class DaysController : Controller
    {
        [HttpGet()]
        public IActionResult GetDay()
        {
            return Ok(DayContext.Current.Days);
        }
        [HttpGet("{id}")]
        public IActionResult GetOneDay(int id)
        {
            var DaytoReturn = DayContext.Current.Days.FirstOrDefault(c => c.Id == id);
            if (DaytoReturn == null)
            { return NotFound(); }
            return Ok(DaytoReturn);
        }
        [HttpDelete("delete/{id}")]
        [HttpPut("update/{id}")]        
        [HttpPost("add/{id}")]
        [HttpGet("test")]
        public IActionResult Test()
        {
            return Test();
        }
        
    }
}