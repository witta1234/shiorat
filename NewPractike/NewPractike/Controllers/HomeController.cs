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
        //[HttpDelete("delete/{id}")]
        [HttpPut("endupdate/{id}")]
        public IActionResult Endupdate(DayContext x)
        {
            string s = "Обновление завершено";
            return Ok(s);
        }
        [HttpPost("endadd")]
        public IActionResult Endadd(DateTime Date1, string Target1)
        {
            int newid = DayContext.Current.Days.Count;
            DaysDTO x =
                new DaysDTO()
                {
                    Id = newid,
                    Date = Date1,
                    Target = Target1,
                    V = 0,
                };
            
            DayContext.Current.Days.Add(x);
            return GetDay();
        }
        [HttpGet("update/{id}")]
        public IActionResult Update(int id)
        {
            var s = DayContext.Current.Days[id - 1];
            return View(s);
        }
        [HttpGet("add")]
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
