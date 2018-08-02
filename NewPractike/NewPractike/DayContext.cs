using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewPractike.Models;

namespace NewPractike
{
    public class DayContext
    {
        public static DayContext Current { get; } = new DayContext();
        public List<DaysDTO> Days { get; set; }
        public DayContext()
        {
            Days = new List<DaysDTO>()
            {
                new DaysDTO()
                {
                    Id=1,
            Date = new DateTime(2018,08,01),
            Target = "Разработка проекта",

        }
            };
        }
    }
}
